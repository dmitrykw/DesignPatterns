using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class SomeClass : IPrototype
    {
        private string _someprivatefield = "some pivate data"; //Данным способом не копируются приватные поля
        public string SomePublicProperty {get; set; } = "some public data";

        public SomeClass()
        {
        }

        public SomeClass(SomeClass prototype)
        {
            SomePublicProperty = prototype.SomePublicProperty;
        }

        public object Clone()
        {
            return new SomeClass(this);
        }
    }
}
