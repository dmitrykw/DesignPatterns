using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.DocumentStates
{
    internal class OnModeration : IState
    {
        private Document _curr_document;
        public OnModeration(Document document)
        {
            _curr_document = document;
        }
        public void Publish()
        {
            _curr_document.ChangeState(new Published(_curr_document));
            Console.WriteLine("Document is set to Published");
        }

        public void Render()
        {
            Console.WriteLine("Document is rendered as OnModeration");
        }
    }
}
