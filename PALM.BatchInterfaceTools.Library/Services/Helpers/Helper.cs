using PALM.BatchInterfaceTools.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Services.Helpers
{
    internal static class Helper
    {
        /// <summary>
        /// Create a delimited string from an object instance, using a specified delimiter, for specified properties. 
        /// </summary>
        /// <typeparam name="T">Type for the corresponding record.</typeparam>
        /// <param name="record">Object instance whose property values should be used in the result string.</param>
        /// <param name="properties">Properties from the object that should be included in the output string.</param>
        /// <param name="delimiter">Character to be used as the delimiter in the output string.</param>
        /// <returns>Returns a delimited string from an object instance, using a specified delimiter, for specified properties.</returns>
        internal static string ComposeRecord<T>(T record, IEnumerable<PropertyInfo> properties, string delimiter = "|")
        {
            return string.Join(
                    delimiter,
                    properties.Select(prop => (prop.GetValue(record) ?? string.Empty).ToString())
                );
        }

        /// <summary>
        /// Create a list of PropertyInfo based on which properties implement the InterfaceFieldPosition attribute.
        /// </summary>
        /// <typeparam name="T">Type for the corresponding attribute.</typeparam>
        /// <returns>Returns list of PropertyInfo based on which properties implement the InterfaceFieldPosition attribute.</returns>
        internal static List<PropertyInfo> ExtractInterfaceFieldProperties<T>()
        {
            return typeof(T)
                .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(prop => Attribute.IsDefined(prop, typeof(InterfaceFieldPosition)))
                .OrderBy(prop => prop.GetCustomAttribute<InterfaceFieldPosition>()?.FieldPosition).ToList();
        }
    }
}
