using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHTML1 myHTML1 = new MyHTML1();            
            Console.WriteLine(myHTML1.GetHTML("mytext1"));

            MyHTML2 myHTML2 = new MyHTML2();
            Console.WriteLine(myHTML2.GetHTML("mytext2"));

            Console.ReadLine();
        }
    }
}
