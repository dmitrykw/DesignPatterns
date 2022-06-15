using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BulletContext
    {
        //Для внутреннего состояния будущего объекта (выбор типа для фабричного метода)
        public BulletTypes BulletType { get; }

        //Для внешнего состояния будущего объекта
        public int X { get;}
        public int Y { get; }
        public int Z { get; }

       
        public BulletContext(BulletTypes bulletType, int x, int y, int z)
        {
            BulletType = bulletType;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
