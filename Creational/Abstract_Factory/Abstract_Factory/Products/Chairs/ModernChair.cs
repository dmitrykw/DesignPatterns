using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Chairs
{
    internal class ModernChair : IChair
    {
        public string GetChairName()
        {
           return "Hello, I`m Modern Chair";
        }
        public string GetName()
        {
            return GetChairName();
        }
    }
}
