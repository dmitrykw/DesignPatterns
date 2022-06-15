using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface ISubscriber
    {
        void Update(object sender, string somedata);
    }
}
