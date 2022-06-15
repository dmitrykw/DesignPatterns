using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Radio radio = new Radio();

            Remote tv_remote = new Remote(tv);
            AdvancedRemote tv_advancedRemote = new AdvancedRemote(tv);

            Remote radio_remote = new Remote(radio);
            AdvancedRemote radio_advancedRemote = new AdvancedRemote(radio);


            tv_remote.VolumeUp();
            tv_remote.VolumeUp();
            tv_remote.VolumeUp();
            tv_remote.TogglePower();
            tv_remote.TogglePower();


            radio_advancedRemote.VolumeUp();
            radio_advancedRemote.VolumeUp();
            radio_advancedRemote.VolumeUp();
            radio_advancedRemote.TogglePower();
            radio_advancedRemote.TogglePower();

            Console.ReadLine();
        }
    }
}
