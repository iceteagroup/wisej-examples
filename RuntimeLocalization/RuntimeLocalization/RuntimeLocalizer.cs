// Adapted from http://rtarlowski.blogspot.com/2011/02/c-change-form-language-at-runtime.html

// This class uses reflection and relies on each Control or Component having a "Name" property

using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using Wisej.Web;

namespace RuntimeLocalization
{
    public class RuntimeLocalizer
    {
        private readonly CultureInfo _cultureInfo;

        public RuntimeLocalizer()
        {
            _cultureInfo = Application.CurrentCulture;
        }

        public void ApplyResources(Form parent)
        {
            Form mainForm = parent;
            while (mainForm.Owner != null)
            {
                mainForm = mainForm.Owner;
            }

            ApplyLanguage(mainForm, null);
        }

        public void ApplyResources(Page parent)
        {
            ApplyLanguage(parent, null);
        }

        private void ApplyLanguage(object value, ComponentResourceManager resources)
        {
            if (value is Form || value is Page)
            {
                resources = new ComponentResourceManager(value.GetType());
                resources.ApplyResources(value, "$this");
            }

            Type type = value.GetType();

            foreach (PropertyInfo info in type.GetProperties())
            {
                switch (info.Name)
                {
                    case "Buttons":
                    case "Items":
                    case "Panels":
                    case "MenuItems":
                    case "DropDownItems":
                    case "Columns":
                    case "Controls":
                    case "OwnedForms":
                    case "SourceControl":

                        if (info.PropertyType.GetInterface("IEnumerable") != null)
                        {
                            IEnumerable collection = (IEnumerable) info.GetValue(value, null);
                            if (collection != null)
                            {
                                foreach (object o in collection)
                                {
                                    PropertyInfo objNameProp = o.GetType().GetProperty("Name");
                                    ApplyResourceOnType(resources, o, objNameProp);
                                }
                            }
                        }

                        break;
                    case "ContextMenuStrip":
                    case "DropDownMenu":
                        object obj = info.GetValue(value, null);
                        if (obj != null)
                        {
                            ApplyLanguage(obj, resources);
                            resources.ApplyResources(obj, info.Name, _cultureInfo);
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private void ApplyResourceOnType(ComponentResourceManager resources, object o, PropertyInfo objNameProp)
        {
            switch (o.GetType().Name)
            {
                case "ComboBox":
                    for (int i = 0; i < ((ComboBox) o).Items.Count; i++)
                    {
                        ((ComboBox) o).Items[i] = resources.GetString(GetItemName(o, objNameProp, i), _cultureInfo);
                    }

                    break;
                case "ListBox":
                    for (int i = 0; i < ((ListBox) o).Items.Count; i++)
                    {
                        ((ListBox) o).Items[i] = resources.GetString(GetItemName(o, objNameProp, i), _cultureInfo);
                    }

                    break;
                // Other classes with string items
                default:
                    if (objNameProp != null)
                    {
                        string name = objNameProp.GetValue(o, null).ToString();
                        ApplyLanguage(o, resources);
                        resources.ApplyResources(o, name, _cultureInfo);
                    }

                    break;
            }
        }

        private string GetItemName(object o, PropertyInfo objNameProp, int i)
        {
            string name = String.Format("{0}.{1}",
                objNameProp.GetValue(o, null),
                "Items");
            if (i != 0) name = String.Format("{0}{1}", name, i);
            return name;
        }
    }
}