using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Tables
{
    internal interface ITable : IProduct
    {
        string GetTableName();
    }
}
