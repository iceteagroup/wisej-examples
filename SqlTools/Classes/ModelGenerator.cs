using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace SqlTools.Classes
{
    public static class ModelGenerator
    {
        public static string GenerateCode(List<DBColumn> columnList, string tableName, string nameSpace, bool implementPropertyChanged, bool useAttributes)
        {
            if (columnList is null)
                throw new ArgumentNullException(nameof(columnList));

            if (string.IsNullOrEmpty(tableName))
                return "";

            if (implementPropertyChanged)
                return GeneratePropertyChanged(columnList, tableName, nameSpace, useAttributes);
            return GenerateStandard(columnList, tableName, nameSpace, useAttributes);
        }

        public static string GenerateAttributes(string nameSpace)
        {

            return
                "using System;\r\n" +
                $"namespace {nameSpace}\r\n" +
                "{\r\n" +
                "	[AttributeUsage(AttributeTargets.Property)]\r\n" +
                "	public class PK : Attribute { }\r\n" +
                "\r\n" +
                "	[AttributeUsage(AttributeTargets.Class)]\r\n" +
                "	public class Tablename : Attribute\r\n" +
                "	{\r\n" +
                "		public Tablename(string name)\r\n" +
                "		{\r\n" +
                "			Name = name;\r\n" +
                "		}\r\n" +
                "\r\n" +
                "		public string Name { get; set; }\r\n" +
                "	}\r\n" +
                "}\r\n";
        }

        public static string GenerateBaseModel(string nameSpace)
        {
            return
                "using System.Collections.Generic;\r\n" +
                "using System.ComponentModel;\r\n" +
                "using System.Runtime.CompilerServices;\r\n" +
                "\r\n" +
                $"namespace {nameSpace}\r\n" +
                "{\r\n" +
                "	public class BaseModel : INotifyPropertyChanged\r\n" +
                "	{\r\n" +
                "		/* \r\n" +
                "		// sample:\r\n" +
                "		public DateTime? DateOfBirth {\r\n" +
                "			get => GetValue<DateTime?>();\r\n" +
                "			set => SetValue(value);\r\n" +
                "		}\r\n" +
                "		*/\r\n" +
                "				\r\n" +
                "		public event PropertyChangedEventHandler PropertyChanged;\r\n" +
                "		protected Dictionary<string, object> Values = new Dictionary<string, object>();\r\n" +
                "\r\n" +
                "		public BaseModel()\r\n" +
                "		{\r\n" +
                "			InitializeDefaultValues();\r\n" +
                "		}\r\n" +
                            "\r\n" +
                "		protected T GetValue<T>([CallerMemberName] string name = \"\")\r\n" +
                "		{\r\n" +
                "			if (Values.TryGetValue(name, out object value))\r\n" +
                "				return (T)value;\r\n" +
                "			return default;\r\n" +
                "		}\r\n" +
                "\r\n" +
                "		protected void SetValue(object value, [CallerMemberName] string name = \"\")\r\n" +
                "		{\r\n" +
                "			Values.TryGetValue(name, out object oldValue);\r\n" +
                "			if (!Equals(oldValue, value))\r\n" +
                "			{\r\n" +
                "				Values[name] = value;\r\n" +
                "				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));\r\n" +
                "			}\r\n" +
                "		}\r\n" +
                "\r\n" +
                "		public virtual void InitializeDefaultValues() { }\r\n" +
                "	}\r\n" +
                "}\r\n";
        }

        private static string GenerateStandard(List<DBColumn> columnList, string tableName, string nameSpace, bool useAttributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"namespace {nameSpace}");
            sb.AppendLine("{");
            if(useAttributes)
                sb.AppendLine($"\t[Tablename(\"{tableName}\")]");
            sb.AppendLine($"\tpublic class {SingularOf(tableName)}");
            sb.AppendLine("\t{");

            foreach (DBColumn column in columnList)
            {
                string r = !column.Required && column.CSharpType != "string" ? "?" : "";
                if (column.IsPrimaryKey && useAttributes)
                    sb.AppendLine("\t\t[PK]");
                sb.AppendLine($"\t\tpublic {column.CSharpType}{r} {column.Name}  {{ get; set; }}");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string GeneratePropertyChanged(List<DBColumn> columnList, string tableName, string nameSpace, bool useAttributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"namespace {nameSpace}.Models");
            sb.AppendLine("{");
            if (useAttributes)
                sb.AppendLine($"\t[Tablename(\"{tableName}\")]");
            sb.AppendLine($"\tpublic class {SingularOf(tableName)} : BaseModel");
            sb.AppendLine("\t{");

            foreach (DBColumn column in columnList)
            {
                string r = !column.Required && column.CSharpType != "string" ? "?" : "";
                if (column.IsPrimaryKey && useAttributes)
                    sb.AppendLine("\t\t[PK]");
                sb.AppendLine($"\t\tpublic {column.CSharpType}{r} {column.Name}");
                sb.AppendLine($"\t\t{{");
                sb.AppendLine($"\t\t\tget => GetValue<{column.CSharpType}{r}>();");
                sb.AppendLine($"\t\t\tset => SetValue(value);");
                sb.AppendLine($"\t\t}}");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string SingularOf(string value)
        {
            string result;
            if (value.Length < 3)
                result = value;
            else if (value.EndsWith("ies", StringComparison.OrdinalIgnoreCase))
            {
                if(IsVowel(value.Substring(value.Length - 2)))
                    result = value.Substring(0, value.Length - 3) + "y";
                else
                    result = value.Substring(0, value.Length - 1);
            }
            else if (value.EndsWith("ues", StringComparison.OrdinalIgnoreCase))
                result = value.Substring(0, value.Length - 1);
            else if (value.Substring(value.Length - 2).ToLower() == "e")
                result = value.Substring(0, value.Length - 1);
            else if (value.EndsWith("es", StringComparison.OrdinalIgnoreCase))
                result = value.Substring(0, value.Length - 2);
            else if (value.EndsWith("s", StringComparison.OrdinalIgnoreCase))
                result = value.Substring(0, value.Length - 1);
            else
                result = value;
            return result.Substring(0, 1).ToUpper() + result.Substring(1).ToLower();
        }

        private static bool IsVowel(string value)
        {
            char c = value[0];
            foreach(char v in "aeoiu")
                if(c == v)
                    return true;
            return false;
        }
    }
}