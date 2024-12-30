using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class InterfaceFieldPosition : Attribute
    {
        internal InterfaceFieldPosition(int fieldPosition)
        {
            FieldPosition = fieldPosition;
        }
        public int FieldPosition { get; set; }
    }
}
