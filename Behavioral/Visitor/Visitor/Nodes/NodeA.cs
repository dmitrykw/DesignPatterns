using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class NodeA : INode
    {
        public string Name { get; set; }
        public string Data { get; set; }

        public NodeA()
        {
            Name = "John Smith";
            Data = "Some data from NodeA";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
