using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private int _random_int; 

        private static Singleton instance;

        private Singleton()
        {
            Random rnd = new Random();
            _random_int = rnd.Next(0, 99999);
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public int GetRandomNumber()
        {
           return _random_int;
        }

    }
}
