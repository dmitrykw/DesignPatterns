using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creatingBulletContext = new BulletContext(BulletTypes.GrayBullet, 150, 250, 350);

            BulletFactory factory = new BulletFactory();

            for (int i = 0; i < 10; i++)
            { 
                AbstractBullet gray_bullet = factory.GetBullet(creatingBulletContext);

                gray_bullet.DrawBullet(creatingBulletContext);
            }

            Console.ReadLine();
        }
    }
}
