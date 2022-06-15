using State.DocumentStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            document.Render();
            document.Publish();

            Console.WriteLine();

            document.Render();
            document.Publish();

            Console.WriteLine();

            document.Render();
            document.Publish();


            Console.ReadLine();
        }
    }
}
