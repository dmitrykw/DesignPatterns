using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class AbstractFactory
    {
        private protected string _product_name;
        public AbstractFactory(string product_name)
        {
            //Some common operations
            _product_name = product_name;
        }
        public abstract IProduct CreateProduct(string description);
    }
}
