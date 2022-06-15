using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            Console.WriteLine(someClass.SomePublicProperty);

            someClass.SomePublicProperty = "qwerty";

            SomeClass someClass1 = (SomeClass)someClass.Clone();
            Console.WriteLine(someClass1.SomePublicProperty);

            someClass1.SomePublicProperty= "asd";

            SomeClass someClass2 = someClass1.DeepCopy();
            Console.WriteLine(someClass2.SomePublicProperty);
            Console.WriteLine(someClass2.Name);

            Console.WriteLine("");
            Console.WriteLine("Changing private value");
            Console.WriteLine("");

            Console.WriteLine(someClass2.GetPrivatalue());
            someClass2.ChangePrivateField("new private value");

            SomeClass someClass3 = (SomeClass)someClass2.Clone();
            Console.WriteLine(someClass3.GetPrivatalue());


            Console.ReadLine();
        }
    }
}
