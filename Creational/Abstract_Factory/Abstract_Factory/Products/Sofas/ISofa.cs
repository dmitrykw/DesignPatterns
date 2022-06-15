using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Sofas
{
    internal interface ISofa : IProduct
    {
        string GetSofaName();
    }
}
