using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.DocumentStates
{
    internal class Draft : IState
    {
        private Document _curr_document;
        public Draft(Document document)
        {
            _curr_document = document;
        }

        public void Publish()
        {
            _curr_document.ChangeState(new OnModeration(_curr_document));
            Console.WriteLine("Document is set on moderation");
        }

        public void Render()
        {
            Console.WriteLine("Document is rendered as Draft");
        }
    }
}
