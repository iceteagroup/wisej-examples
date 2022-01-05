namespace SqlTools.Classes
{
    public class DBColumn
    {
        public string Name { get; set; }
        public string SqlType { get; set; }
        public int Length { get; set; }
        public bool Required { get; set; }
        public bool IsPrimaryKey { get; set; }
        public string CSharpType
        {
            get
            {
                switch (SqlType)
                {
                    case "int":
                        return "int";
                    case "char":
                    case "nchar":
                    case "varchar":
                    case "nvarchar":
                    case "text":
                    case "ntext":
                        return "string";
                    case "bit":
                        return "bool";
                    case "float":
                        return "float";
                    case "datetime":
                    case "smalldatetime":
                    case "date":
                    case "smalldate":
                        return "DateTime";
                    case "image":
                        return "byte[]";
                    case "money":
                    case "decimal":
                        return "decimal";
                    default:
                        return $"[{SqlType.ToUpper()}]";
                }
            }
        }
    }
}