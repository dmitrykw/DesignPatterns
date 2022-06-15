using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ShopProxy : IShop
    {
        private readonly Shop _shop;

        public ShopProxy(Shop shop)
        {
            _shop = shop;
        }

        public void PayMoney(int amount)
        {
            Console.WriteLine("Payment ${0} Logged", amount);
            _shop.PayMoney(amount);
        }
    }
}
