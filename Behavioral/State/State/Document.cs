using State.DocumentStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Document
    {
        private IState _curr_state;

        public Document()
        {
            _curr_state = new Draft(this);
        }

        public void Render()
        {
            _curr_state.Render();
        }
        public void Publish()
        {
            _curr_state.Publish();
        }
        public void ChangeState(IState state)
        {
            _curr_state = state;
        }
    }
}
