using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class TemplateClass
    {
        public virtual void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
            Step4();
            Step5();
        }

        public virtual void Step1()
        {
            Console.WriteLine("Execute Step1 from Template");
        }

        public virtual void Step2()
        {
            Console.WriteLine("Execute Step2 from Template");
        }
        public abstract void Step3();
      
        public virtual void Step4()
        {
            Console.WriteLine("Execute Step4 from Template");
        }
        public abstract void Step5();
    }
}
