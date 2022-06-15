using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class GrayBullet : AbstractBullet
    {
        public override string Color => "GrayColor";  //Внутреннее состояние
        public override string SpritePic => "GraySpritePic.jpg";   //Внутреннее состояние  

        public override void DrawBullet(BulletContext curr_context)  //Внешнее состояние
        {
            Console.WriteLine($"Returned bullet with {Color} and {SpritePic} in coordinates: x{curr_context.X}; y{curr_context.Y}; z{curr_context.Z};");
        }
    }
}
