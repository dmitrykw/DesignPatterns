using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Cars
{
    internal interface ICar
    {
        string Name { get; }
        string Description { get; }
    }
}
