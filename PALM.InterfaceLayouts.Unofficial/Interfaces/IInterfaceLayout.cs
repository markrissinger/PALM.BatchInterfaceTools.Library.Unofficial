using PALM.InterfaceLayouts.Unofficial.Attributes;
using System.Collections;
using System.Reflection;
using System.Text;

namespace PALM.InterfaceLayouts.Unofficial.Interfaces
{
    public interface IInterfaceLayout
    {
        public string InterfaceID { get; }

        public byte[] WriteRecordsToByteArray();
        public StringBuilder WriteRecordsToStringBuilder();
        public void WriteRecordsToFile();
    }
}
