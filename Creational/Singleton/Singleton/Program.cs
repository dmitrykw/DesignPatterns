using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.GetRandomNumber());

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.GetRandomNumber());

            Singleton singleto3 = Singleton.GetInstance();
            Console.WriteLine(singleto3.GetRandomNumber());

            //Return the same integers because Singleton.GetInstance() return the same instances of Singleton object every time

            Console.ReadLine();
        }
    }
}
