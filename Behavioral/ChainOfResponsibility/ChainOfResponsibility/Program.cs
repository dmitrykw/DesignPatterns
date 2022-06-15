using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "John Smith";

            var handler = new CorrectRequestHandler().SetNextHandler(new AuthentificationHandler()).SetNextHandler(new AuthorizationHandler());

            bool result = handler.HandleRequest(username);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
