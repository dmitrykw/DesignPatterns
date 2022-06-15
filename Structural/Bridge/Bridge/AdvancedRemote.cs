using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class AdvancedRemote : Remote
    {
        private int _saved_volume;
        internal AdvancedRemote(IDevice device) : base(device)
        {
        }

        internal void Mute()
        {
            if (_device.GetVolume() > 0)
            {
                _saved_volume = _device.GetVolume();
                _device.SetVolume(0);
            }
            else
            {
                _device.SetVolume(_saved_volume);
            }
        }
    }
}
