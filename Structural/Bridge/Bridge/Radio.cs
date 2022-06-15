using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Radio : IDevice
    {
        private int _current_channel;
        private int _current_volume;

        public bool isEnabled {get; set; }

        public void Disable()
        {
            isEnabled = false;
            Console.WriteLine("Radio Disabled");
        }

        public void Enable()
        {
            isEnabled = true;
            Console.WriteLine("Radio Enabled");
        }

        public int GetChannel()
        {
            return _current_channel;
        }

        public int GetVolume()
        {
            return _current_volume;
        }

        public void SetChannel(int channel)
        {
           _current_channel = channel;
            Console.WriteLine("Channel set to " + channel);
        }

        public void SetVolume(int percent)
        {
            _current_volume = percent;
            Console.WriteLine("Volume set to " + percent);
        }
    }
}
