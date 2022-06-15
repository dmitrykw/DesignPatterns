using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subscriber1 : ISubscriber
    {      
        public void Update(object sender, string somedata)
        {
            Console.WriteLine("Subscriber1 has received event from: '{0}' with data: '{1}'", sender.ToString() , somedata );
        }
    }
}
