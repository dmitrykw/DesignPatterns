using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class NodeB : INode
    {
        public string SomeInfo { get; set; }
        public int DataValue { get; set; }

        public NodeB()
        {
            SomeInfo = "Some info from NodeB";
            DataValue = 456;
        }
        

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
