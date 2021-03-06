using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Visitor1 : IVisitor
    {
        public void Visit(NodeA node)
        {
            Console.WriteLine("FIRST VISITOR: '{0}' '{1}'", node.Name, node.Data);
        }

        public void Visit(NodeB node)
        {
            Console.WriteLine("FIRST VISITOR: '{0}' '{1}'", node.DataValue, node.SomeInfo);
        }



        //public void Visit(INode node) //ALTERNATIVE POLIMORPHIC VARIANT
        //{
        //    if (node is NodeA nodeA)
        //    {
        //        Console.WriteLine("FIRST VISITOR: '{0}' '{1}'", nodeA.Name, nodeA.Data);
        //    }
        //    else if (node is NodeB nodeB)
        //    {
        //        Console.WriteLine("FIRST VISITOR: '{0}' '{1}'", node.DataValue, node.SomeInfo);
        //    }
        //}


    }
}
