using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.DocumentStates
{
    internal interface IState
    {
        void Render();
        void Publish();
    }
}
