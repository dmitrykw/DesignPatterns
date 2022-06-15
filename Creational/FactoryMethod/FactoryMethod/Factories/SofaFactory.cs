using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class SofaFactory : AbstractFactory
    {
        public SofaFactory(string sofa_name) : base(sofa_name)
        {
            //Some specified for Chair operations
        }
        public override IProduct CreateProduct(string sofa_description)
        {
            return new Sofa(_product_name) {Description = sofa_description };
        }
    }
}
