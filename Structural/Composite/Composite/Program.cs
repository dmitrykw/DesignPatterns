using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thing thing1 = new Thing(15);
            Thing thing2 = new Thing(150);
            Thing thing3 = new Thing(250);
            Thing thing4 = new Thing(1500);
            Thing thing5 = new Thing(350);

            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();
            Box box5 = new Box();

            box1.Add(box2.Add(box3.Add(thing1)));
            box1.Add(thing2);
            box1.Add(box4.Add(box5.Add(thing3)));
            box4.Add(thing4);
            box5.Add(thing5);

            Console.WriteLine(box4.GetPrice());

            Console.ReadLine();

        }
    }
}
