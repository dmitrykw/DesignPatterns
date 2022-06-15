using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IRouteStrategy
    {
        void BuildRoute(int point_a, int point_b);
    }
}
