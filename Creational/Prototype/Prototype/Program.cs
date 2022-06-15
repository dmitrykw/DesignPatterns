using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            Console.WriteLine(someClass.SomePublicProperty);
            someClass.SomePublicProperty = "New data";

            SomeClass someClass1 = (SomeClass)someClass.Clone();
            Console.WriteLine(someClass1.SomePublicProperty);

            Console.ReadLine();
        }
    }
}
