using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Remote
    {
        private protected readonly IDevice _device;
        internal Remote(IDevice device)
        {
            this._device = device;
        }

        internal void TogglePower()
        {
            if (_device.isEnabled) { 
            _device.Disable(); }
            else { _device.Enable(); }
        }

        internal void VolumeDown()
        {
           _device.SetVolume(_device.GetVolume() - 1);
        }

        internal void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 1);
        }

        internal void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        internal void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }
    }
}
