using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlTools.Classes
{
    public static class SqlGenerator
    {
        private const string INDENT = "\t";

        public static string GenerateSelect(
            List<DBColumn> columnList,
            int fieldsPerLine,
            string tableName,
            string tableAlias,
            bool qualifiedNames,
            bool fieldAliases,
            bool brackets
            )
        {
            string alias = string.IsNullOrEmpty(tableAlias) ? tableName : tableAlias;
            string tableFrom = AddBrackets(tableName, brackets) + (!string.IsNullOrEmpty(tableAlias) ? $" as {AddBrackets(tableAlias, brackets)}" : "");

            List<string> fieldList = GetListOfFields(columnList);
            string fields = ListToString(fieldList, fieldsPerLine, x =>
            {
                string result = AddBrackets(x, brackets);
                if (qualifiedNames)
                {
                    string tmp = AddBrackets(alias, brackets);
                    result = $"{tmp}.{result}";
                }
                if (fieldAliases)
                {
                    result += " as " + AddBrackets($"{alias}_{x}", brackets);
                }
                return result;
            });

            return $"select\r\n{fields}\r\nfrom {tableFrom}";
        }

        public static string GenerateUpdate(
            List<DBColumn> columnList,
            int fieldsPerLine,
            string tableName,
            bool brackets
            )
        {
            List<string> fieldList = GetListOfFields(columnList.Where(x => !x.IsPrimaryKey).ToList());
            string fields = ListToString(fieldList, fieldsPerLine, x => AddBrackets(x, brackets) + " = " + AddBrackets($"@{x}", brackets));
            return $"update {AddBrackets(tableName, brackets)} set\r\n{fields}";
        }

        public static string GenerateInsert(
            List<DBColumn> columnList,
            int fieldsPerLine,
            string tableName,
            bool brackets
            )
        {
            List<string> fieldList = GetListOfFields(columnList);
            string fields = ListToString(fieldList, fieldsPerLine, x => AddBrackets(x, brackets));
            string values = ListToString(fieldList, fieldsPerLine, x => AddBrackets($"@{x}", brackets));
            return $"insert into {AddBrackets(tableName, brackets)} (\r\n{fields}\r\n) values (\r\n{values}\r\n)";
        }

        private static List<string> GetListOfFields(List<DBColumn> columnList)
        {
            List<string> list = new List<string>();
            foreach (DBColumn column in columnList)
            {
                list.Add(column.Name);
            }
            return list;
        }

        private static string AddBrackets(string value, bool brackets)
        {
            return brackets ? $"[{value}]" : value;
        }

        private static string ListToString(List<string> fieldList, int fieldsPerLine, Func<string, string> expressionBuildFunc)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < fieldList.Count; i++)
            {
                string field = fieldList[i];
                if (i > 0)
                {
                    if (i % fieldsPerLine == 0)
                    {
                        sb.Append(',');
                        sb.Append(Environment.NewLine);
                        sb.Append(INDENT);
                        sb.Append(expressionBuildFunc(field));
                    }
                    else
                    {
                        sb.Append(", ");
                        sb.Append(expressionBuildFunc(field));
                    }
                }
                else
                {
                    sb.Append(INDENT);
                    sb.Append(expressionBuildFunc(field));
                }

            }
            return sb.ToString();
        }
    }
}