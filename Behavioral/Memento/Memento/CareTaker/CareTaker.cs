using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class CareTaker
    {
        private IOriginator _originator = null;

        private Stack<IMemento> _previous_mementos = new Stack<IMemento>();
        private Stack<IMemento> _future_mementos = new Stack<IMemento>();



        public CareTaker(IOriginator originator)
        {
            this._originator = originator;
        }

        public void AddSnapshop()
        {
            _previous_mementos.Push(_originator.MakeSnapshot());
            _future_mementos.Clear();
        }

        public void Undo()
        {
            if (_previous_mementos.Any())
            {
                var snapshot = _previous_mementos.Pop();
                _future_mementos.Push(_originator.MakeSnapshot());

                snapshot.Restore();
            }
        }

        public void Forward()
        {
            if (_future_mementos.Any())
            {
                var snapshot = _future_mementos.Pop();
                _previous_mementos.Push(_originator.MakeSnapshot());

                snapshot.Restore();
            }
        }

        public string ShowHistory()
        {
            string result = "Caretaker: Here's the list of previous mementos:\n";
            
            foreach (var memento in _previous_mementos)
            {
                result += memento.GetSnapshotDate() + " " + memento.GetSnapshotTextAndCoursorIndex() + "\n";
            }
            return result;
        }
    }
}
