using PALM.InterfaceLayouts.Unofficial.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.Services.Utilities
{
    internal static class Helper
    {
        internal static string ComposeRecord<T>(T record, List<PropertyInfo> properties, string delimiter = "|")
        {
            return string.Join(
                    delimiter,
                    properties.Select(prop => (prop.GetValue(record) ?? string.Empty).ToString())
                );
        }

        internal static List<PropertyInfo> ExtractInterfaceFieldProperties<T>()
        {
            return typeof(T)
                .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(prop => Attribute.IsDefined(prop, typeof(InterfaceFieldPosition)))
                .OrderBy(prop => prop.GetCustomAttribute<InterfaceFieldPosition>()?.FieldPosition).ToList();
        }
    }
}
