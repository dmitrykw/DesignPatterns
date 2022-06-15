using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal abstract class AbstractBullet
    {
        public AbstractBullet()
        {
            //Some init operations for all child classses
        }

        public abstract string Color {get; }  //Внутреннее состояние
        public abstract string SpritePic {get; }   //Внутреннее состояние     

        public abstract void DrawBullet(BulletContext curr_context);  //Внешнее состояние
    }
}
