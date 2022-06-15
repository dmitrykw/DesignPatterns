using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.AppLayers
{
    internal interface IReceiveLayer
    {
        void SaveText(string text);
    }
}
