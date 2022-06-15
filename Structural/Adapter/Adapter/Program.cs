using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            USBController usbController = new USBController("My USB Controller");

            USBFlashDrive flashDrive = new USBFlashDrive("My USB FlashDrive");
            flashDrive.InsertToUSBPort(usbController);

            CardReader cardReader = new CardReader("My Card Reader");
            cardReader.InsertToUSBPort(usbController);

            cardReader.InserMemoryCard(new MemoryCard());

            Console.WriteLine();
            Console.WriteLine("USB Adapter Connected Devices:");
            foreach(IUSBDevice device in usbController.ConnectedDevices)
            {
                Console.WriteLine(device.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Читаем данные из контроллера с подкюченных устройств");
            foreach (IUSBDevice device in usbController.ConnectedDevices)
            {
                Console.WriteLine(device.ReadData());
            }


            Console.WriteLine();
            Console.WriteLine("Отключаем CardReader от USB");
            usbController.RemoveDevice(usbController.ConnectedDevices.Where(x => x.Name == "My Card Reader").FirstOrDefault());

            Console.WriteLine();
            Console.WriteLine("USB Adapter Connected Devices:");
            foreach (IUSBDevice device in usbController.ConnectedDevices)
            {
                Console.WriteLine(device.Name);
            }

            Console.ReadLine();
        }
    }
}
