using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class ChairsFactory : AbstractFactory
    {
        public ChairsFactory(string chair_name) : base(chair_name)
        {
            //Some specified for Chair operations
        }
        public override IProduct CreateProduct(string chair_description)
        {
            return new Chair(_product_name) {Description = chair_description };
        }
    }
}
