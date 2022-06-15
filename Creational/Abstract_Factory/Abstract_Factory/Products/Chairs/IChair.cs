using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Chairs
{
    internal interface IChair: IProduct
    {
        string GetChairName();
    }
}
