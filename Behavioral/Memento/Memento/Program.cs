using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            CareTaker careTaker = new CareTaker(textEditor);

            careTaker.AddSnapshop();
            textEditor.SetState("q", 1);           
            Console.WriteLine(textEditor.GetCurrentTextAndCoursorIndex());

            careTaker.AddSnapshop();
            textEditor.SetState("qw", 2);            
            Console.WriteLine(textEditor.GetCurrentTextAndCoursorIndex());
            
            careTaker.AddSnapshop();
            textEditor.SetState("qwe", 3);            
            Console.WriteLine(textEditor.GetCurrentTextAndCoursorIndex());


            do
            {
                Console.WriteLine("Enter undo or redo?");

                string answer = Console.ReadLine();
                if (answer == "undo")
                {
                    careTaker.Undo();
                    Console.WriteLine(textEditor.GetCurrentTextAndCoursorIndex());
                }
                else if (answer == "redo")
                {
                    careTaker.Forward();
                    Console.WriteLine(textEditor.GetCurrentTextAndCoursorIndex());
                }


                Console.WriteLine(careTaker.ShowHistory());
            }
            while(true);

         
        }
    }
}
