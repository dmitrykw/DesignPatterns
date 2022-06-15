using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class USBController
    {
        private List<IUSBDevice> connectedDevices = new List<IUSBDevice>();
        public string Name { get; private set; }
        internal USBController(string controller_name)
        {
            this.Name = controller_name;
        }
      
        public List<IUSBDevice> ConnectedDevices => connectedDevices;        
        public void InsertDevice(IUSBDevice device)
        {
            connectedDevices.Add(device);
        }       
        public void RemoveDevice(IUSBDevice device)
        {
            connectedDevices.Remove(device);
        }
    }
}
