using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Shop : IShop
    {
        int _kassa = 0;
        public void PayMoney(int amount)
        {
            _kassa += amount;
        }

        public int GetKassa()
        {
            return _kassa;
        }
    }
}
