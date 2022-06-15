using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class RedBullet : AbstractBullet
    {
        public override string Color => "RedColor";             //Внутреннее состояние - большой тяжеловесный объект ради которого всё и делается
        public override string SpritePic => "RedSpritePic.jpg"; //Внутреннее состояние - большой тяжеловесный объект ради которого всё и делается

        public override void DrawBullet(BulletContext curr_context)  //Внешнее состояние - изменяемые объекты
        {
            Console.WriteLine($"Returned bullet with {Color} and {SpritePic} in coordinates: x{curr_context.X}; y{curr_context.Y}; z{curr_context.Z};");
        }
    }
}