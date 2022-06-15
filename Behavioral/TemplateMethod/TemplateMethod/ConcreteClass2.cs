using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ConcreteClass2 : TemplateClass
    {
        public override void Step3()
        {
            Console.WriteLine("Execute Step3 from ConcreteClass2");
        }

        public override void Step5()
        {
            Console.WriteLine("Execute Step5 from ConcreteClass2");
        }
    }
}
