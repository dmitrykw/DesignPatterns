using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class TablesFactory : AbstractFactory
    {
        public TablesFactory(string table_name) : base(table_name)
        {
            //Some specified for Chair operations
        }
        public override IProduct CreateProduct(string table_description)
        {
            return new Table(_product_name) {Description = table_description };
        }
    }
}
