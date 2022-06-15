using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class USBFlashDrive : IUSBDevice
    {
        public string Name { get; private set; }
        internal USBFlashDrive(string flash_name)
        {
            this.Name = flash_name;
        }
        public void EjectFromUSBPort(USBController controller)
        {
            controller.RemoveDevice(this);
            Console.WriteLine("Флешка успешно извлечена из USB порта контроллера " + controller.Name);
        }

        public void InsertToUSBPort(USBController controller)
        {
          controller.InsertDevice(this);
          Console.WriteLine("Флешка успешно вставлена в USB порт контроллера " + controller.Name);
        }

        public string ReadData()
        {
           return "Some content stored in " + Name;
        }
    }
}
