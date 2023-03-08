using DevExpress.DashboardWeb.Native;
using DevExpress.Web.Internal;
using System.Collections;

namespace Wisej.DxDashboardSample
{
    public class WisejJsonSerializer : IJsonSerializer
    {
        public Hashtable JsonToHashtable(string json)
        {
            return (Hashtable)HtmlConvertor.FromJSON(json);
        }

        public object JsonToObject(string json)
        {
            return HtmlConvertor.FromJSON(json);
        }

        public string ObjectToJson(object value)
        {
            JSONOptions opts = new JSONOptions
            {
                UseDoubleQuotesMark = true,
                ProcessStructs = true,
                DateFormat = JSONDateFormat.JSONIsoDateFormat,
                AddRoundBrackets = false,
                ConvertBytesToBase64 = true,
                ProcessRecursiveObjects = false,
                EnableTruncatedUnicodeNumbers = false
            };
            return HtmlConvertor.ToJSON(value, opts);
        }
    }
}
