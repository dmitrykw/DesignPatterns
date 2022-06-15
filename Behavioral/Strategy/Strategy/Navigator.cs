using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Navigator : IRouteStrategy
    {
        IRouteStrategy _routeStrategy;

        public void SetStrategy(IRouteStrategy strategy)
        {
            _routeStrategy = strategy;
        }

        public void BuildRoute(int point_a, int point_b)
        {
            if (_routeStrategy != null)
            {
                _routeStrategy.BuildRoute(point_a, point_b);
                return;
            }
            
            Console.WriteLine("No strategy");
        }
    }
}
