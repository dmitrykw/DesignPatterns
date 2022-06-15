using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private string _myState = "Some business data";

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(this, _myState);
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Enter 'notify' if you want to notify all suscribers");

            if (Console.ReadLine() == "notify")
            {
                NotifySubscribers();
            }
        }


        public override string ToString()
        {
            return "My Publisher class";
        }
    }
}
