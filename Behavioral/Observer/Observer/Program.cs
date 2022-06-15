using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber1 subscriber1 =  new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            while(true)
            {
                publisher.DoSomething();
            }            
        }
    }
}
