using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Thing : IItem
    {
        private int _price;

        public Thing(int price)
        {
            _price = price;
        }       

        public int GetPrice()
        {
            return _price;
        }        
    }
}
