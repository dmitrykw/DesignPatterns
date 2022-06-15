﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface IDevice
    {
        bool isEnabled { get; }
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChannel(int channel);
    }
}
