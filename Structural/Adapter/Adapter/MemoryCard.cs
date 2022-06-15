using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MemoryCard
    {
        public void InsertCard()
        {
            Console.WriteLine("Карта памяти успешно вставлена!");
        }

        public void RemoveCard()
        {
            Console.WriteLine("Карта памяти успешно вставлена!");
        }

        public string ReadCardData() 
        {
            return "Some data stored on MemoryCard";
        }
    }
}
