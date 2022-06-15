﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(int point_a, int point_b)
        {
            Console.WriteLine("Builded Route for PUBLIC-TRANSPORT from Point {0} to Point {1}", point_a, point_b);
        }
    }
}
