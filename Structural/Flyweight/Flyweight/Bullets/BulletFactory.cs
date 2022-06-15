using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BulletFactory
    {
        private Dictionary<BulletTypes, AbstractBullet> bullets_cache = new Dictionary<BulletTypes, AbstractBullet>();

        public AbstractBullet GetBullet(BulletContext bulletContext)
        {
            if (bullets_cache.ContainsKey(bulletContext.BulletType))
            { return bullets_cache[bulletContext.BulletType]; }
            else
            {
                AbstractBullet bullet;
                switch (bulletContext.BulletType)
                {
                    case BulletTypes.RedBullet:
                        bullet = new RedBullet(); 
                        break;

                    case BulletTypes.GrayBullet:
                        bullet = new GrayBullet();
                        break;

                    case BulletTypes.GreenBullet:
                        bullet = new GreenBullet();
                        break;

                    default:
                        bullet = null;
                        break;
                }
                return bullet;
            }    

        }
    }
}
