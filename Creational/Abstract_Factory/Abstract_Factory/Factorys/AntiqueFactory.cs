using Abstract_Factory.Products.Chairs;
using Abstract_Factory.Products.Sofas;
using Abstract_Factory.Products.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factorys
{
    internal class AntiqueFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new AntiqueChair();
        }

        public ITable CreateTable()
        {
            return new AntiqueTable();
        }

        public ISofa CreatewSofa()
        {
            return new AntiqueSofa();
        }
    }
}
