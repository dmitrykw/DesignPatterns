using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class CardReader : IUSBDevice
    {
        public string Name { get; private set; }
        internal CardReader(string cardReaderName)
        {
            this.Name = cardReaderName;
        }

        private MemoryCard _memoryCard;

        public void EjectFromUSBPort(USBController controller)
        {
            controller.RemoveDevice(this);
            Console.WriteLine(Name +" успешно извлечен из USB порта контроллера " + controller.Name);
        }

        public void InsertToUSBPort(USBController controller)
        {
            controller.InsertDevice(this);
            Console.WriteLine(Name +" успешно вставлен в USB порт контроллера " + controller.Name);
        }

        public void InserMemoryCard(MemoryCard card)
        {
            if (_memoryCard == null)
            { 
                this._memoryCard = card;
                Console.WriteLine("Memory card успешно вставлена в кардреадер " + Name);
            }
            else { throw new Exception("MemoryCard already inserted");}
        }

        public void Remove(MemoryCard card)
        {
            _memoryCard = null;
            Console.WriteLine("Memory card успешно извлечена из кардреадера " + Name);
        }

        public string ReadData()
        {
            return _memoryCard.ReadCardData();
        }
    }
}
