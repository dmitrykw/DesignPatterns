using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IUSBDevice
    {
        string Name { get; }
        string ReadData();
        void InsertToUSBPort(USBController controller);
        void EjectFromUSBPort(USBController controller);
    }
}
