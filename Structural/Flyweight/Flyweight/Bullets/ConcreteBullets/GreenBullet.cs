using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class GreenBullet : AbstractBullet
    {
        public override string Color => "GreenColor";  //Внутреннее состояние
        public override string SpritePic => "GreenSpritePic.jpg";   //Внутреннее состояние  

        public override void DrawBullet(BulletContext curr_context)  //Внешнее состояние
        {
            Console.WriteLine($"Returned bullet with {Color} and {SpritePic} in coordinates: x{curr_context.X}; y{curr_context.Y}; z{curr_context.Z};");
        }
    }
}
