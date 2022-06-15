using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.PayMoney(5);
            Console.WriteLine("Current amount in kassa ${0}", shop.GetKassa());

            ShopProxy shopProxy = new ShopProxy(shop);
            shopProxy.PayMoney(15);

            Console.WriteLine("Current amount in kassa ${0}", shop.GetKassa());

            Console.ReadLine();
        }
    }
}
