using Command.AppLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvokeLayer invokeLayer = new InvokeLayer();
            invokeLayer.DoSomethingImportant();

            while (Console.ReadLine() == "back")
            { invokeLayer.StepBack(); }
            

            Console.ReadLine();
        }
    }
}
