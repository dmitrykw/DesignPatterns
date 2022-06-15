using Command.AppLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class SaveCommand : ICommand
    {
        private readonly IReceiveLayer _receiveLayer;
        private readonly string _payload = string.Empty;

        internal SaveCommand(IReceiveLayer receiveLayer, string savetext)
        {
            _receiveLayer = receiveLayer;
            _payload = savetext;
        }
        public void Execute()
        {
            _receiveLayer.SaveText(_payload);
            
        }
    }
}
