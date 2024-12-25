using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ChildRecord : Attribute
    {
        internal ChildRecord()
        {
        }
    }
}
