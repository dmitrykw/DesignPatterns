using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    internal class Sofa : IProduct
    {
        private string _name;
        private string _description;
        public Sofa(string name)
        {
            _name = name;
        }
        public string Name => _name;

        public string Description { get => _description; set => _description = value; }
    }
}
