using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;

namespace Command.AppLayers
{
    internal class InvokeLayer
    {
        private Queue<ICommand> _newCommands = new Queue<ICommand>();
        private Stack<ICommand> _executedCommads = new Stack<ICommand>();


        public void DoSomethingImportant()
        {
            string somedata = "qwe";
            if (somedata == "qwe")
            {
                AddCommand(new SaveCommand(new ReceiveLayer(), "Current text is pam"));
                AddCommand(new SaveCommand(new ReceiveLayer(), "Current text is pam pam"));
                AddCommand(new SaveCommand(new ReceiveLayer(), "Current text is pam pam pam"));
            }
            else
            {
                AddCommand(new SaveCommand(new ReceiveLayer(), "some error"));
            }
            ExecuteAllCommands();
        }


        private void AddCommand(ICommand command)
        {
            _newCommands.Enqueue(command);
        }

        private void ExecuteAllCommands()
        {
            while (_newCommands.Any())
            {
                ICommand command = _newCommands.Dequeue();
                command.Execute();
                _executedCommads.Push(command);
            }
        }

        internal void StepBack()
        {
            if (_executedCommads.Any())
            {
                if (_executedCommads.Count() > 1)
                {_executedCommads.Pop();}

                _executedCommads.Pop().Execute();
            }
        }
    }
}
