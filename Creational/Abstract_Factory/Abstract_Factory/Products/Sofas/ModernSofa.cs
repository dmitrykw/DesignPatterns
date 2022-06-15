using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Sofas
{
    internal class ModernSofa : ISofa
    {
        public string GetName()
        {
            return GetSofaName();
        }

        public string GetSofaName()
        {
            return "Hello, I`m Modern Sofa";
        }
    }
}
