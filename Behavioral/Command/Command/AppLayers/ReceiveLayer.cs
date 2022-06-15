using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.AppLayers
{
    internal class ReceiveLayer : IReceiveLayer
    {
        public void SaveText(string text)
        {
            Console.WriteLine("Сохраняем текст {0}", text);
        }
    }
}
