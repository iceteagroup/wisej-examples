using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace SqlTools.Classes
{
    public static class Database
    {
        private static SqlConnection GetConnection(string serverName = null, string databaseName = null)
        {
            if (string.IsNullOrEmpty(serverName))
                serverName = @"(localdb)\MSSQLLocalDB";
            if (string.IsNullOrEmpty(databaseName))
                databaseName = "";

            SqlConnection conn = new SqlConnection($"server={serverName};Integrated Security=SSPI;Initial Catalog='{databaseName}';Data Source={serverName}");
            conn.Open();

            return conn;
        }

        public static List<string> LoadDatabaseNames()
        {
            using (var conn = GetConnection())
            {
                return conn.Query<string>("select Name from master.sys.databases where name not in ('master', 'model', 'msdb', 'tempdb')").ToList();
            }
        }

        public static List<string> LoadTableNames(string serverName, string databaseName)
        {
            using (var conn = GetConnection(serverName, databaseName))
            {
                return conn.Query<string>("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'").ToList();
            }
        }

        public static List<DBColumn> LoadColumns(string serverName, string databaseName, string tableName)
        {
            using (var conn = GetConnection(serverName, databaseName))
            {
                List<DBPrimaryKeyColumn> pkList = conn.LoadPrimaryKeyColumns(tableName);
                List<DBColumn> result = new List<DBColumn>();

                string sqlStatement = $"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
                using (var dataReader = conn.ExecuteReader(sqlStatement))
                {
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(3);
                        string type = dataReader.GetString(7);
                        bool required = dataReader.GetString(6) == "NO";
                        bool isPK = pkList.Any(col => col.TableName == tableName && col.ColumnName == name);
                        int len = 0;
                        if (!dataReader.IsDBNull(8))
                            len = dataReader.GetInt32(8);

                        result.Add(new DBColumn() { Name = name, SqlType = type, Length = len, Required = required, IsPrimaryKey = isPK });
                    }

                    return result;
                }
            }
        }

        private static List<DBPrimaryKeyColumn> LoadPrimaryKeyColumns(this SqlConnection conn, string tableName = null)
        {
            string sqlStatement =
                "select TC.TABLE_NAME, TC.CONSTRAINT_NAME, CCU.COLUMN_NAME\r\n" +
                "from INFORMATION_SCHEMA.TABLE_CONSTRAINTS as TC\r\n" +
                "inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as CCU on TC.CONSTRAINT_NAME = CCU.CONSTRAINT_NAME\r\n" +
                "where TC.CONSTRAINT_TYPE = 'PRIMARY KEY'";
            if (!string.IsNullOrEmpty(tableName))
                sqlStatement += $" and TC.TABLE_NAME = '{tableName}'";

            List<DBPrimaryKeyColumn> list = new List<DBPrimaryKeyColumn>();
            using (var dataReader = conn.ExecuteReader(sqlStatement))
            {
                while (dataReader.Read())
                    list.Add(new DBPrimaryKeyColumn() { TableName = dataReader.GetString(0), ColumnName = dataReader.GetString(2) });

                return list;
            }
        }
    }
}