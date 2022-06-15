using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass1 concreteClass1 = new ConcreteClass1();
            concreteClass1.TemplateMethod();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ConcreteClass2 concreteClass2 = new ConcreteClass2();
            concreteClass2.TemplateMethod();

            Console.ReadLine();
        }
    }
}
