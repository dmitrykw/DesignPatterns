using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        void Visit(NodeA node);
        void Visit(NodeB node);

        //void Visit(INode node); //ALTERNATIVE POLIMORPHIC VARIANT
    }
}
