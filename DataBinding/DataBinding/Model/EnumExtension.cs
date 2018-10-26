//http://codereview.stackexchange.com/questions/39163/loading-a-combobox-with-an-enum-and-binding-to-it

using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Wisej.Web;

namespace DataBinding.Model
{
    internal static class EnumExtension
    {
        // Not used in the project
        /*public static void EnumToComboBox(this ComboBox comboBox, Type enumType)
        {
            comboBox.DataSource = Enum.GetValues(enumType).Cast<Enum>().Select(Key => new
            {
                (Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                Key
            }).OrderBy(item => item.Key).ToList();

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Key";
        }*/

        public static void EnumToDataSource(this BindingSource bindingSource, Type enumType)
        {
            bindingSource.DataSource = Enum.GetValues(enumType).Cast<Enum>().Select(Key => new
            {
                (Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                Key
            }).OrderBy(item => item.Key).ToList();
        }

        // should be used to feed the AutoCompleteCustomSource
        public static string[] EnumToArray(Type enumType)
        {
            return (from object item in Enum.GetValues(enumType)
                select
                    (Attribute.GetCustomAttribute(item.GetType().GetField(item.ToString()),
                            typeof(DescriptionAttribute)) as
                        DescriptionAttribute).Description).ToArray();
        }

        // https://stackoverflow.com/questions/20290842/converter-to-show-description-of-an-enum-and-convert-back-to-enum-value-on-sele

        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            MemberInfo[] memInfo = type.GetMember(value.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute) attrs[0]).Description;
                }
            }

            return value.ToString();
        }
    }
}