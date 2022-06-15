using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Box : IItem
    {
        private readonly List<IItem> _children = new List<IItem>();

        public Box Add(IItem item)
        {
            _children.Add(item);
            return this;
        }



        public int GetPrice()
        {
            int price = 0;
            _children.ForEach(x => price += x.GetPrice());
            return price;
        }
    }
}
