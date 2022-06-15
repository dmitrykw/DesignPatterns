using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NodeA nodeA = new NodeA();
            NodeB nodeB = new NodeB();

            Visitor1 visitor1 = new Visitor1();
            visitor1.Visit(nodeA);
            visitor1.Visit(nodeB);

            Console.WriteLine();

            Visitor2 visitor2 = new Visitor2();
            visitor2.Visit(nodeA);
            visitor2.Visit(nodeB);

            Console.ReadLine();
        }
    }
}
