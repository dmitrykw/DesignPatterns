using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.DocumentStates
{
    internal class Published : IState
    {
        private Document _curr_document;
        public Published(Document document)
        {
            _curr_document = document;
        }

        public void Publish()
        {
            Console.WriteLine("Document is already Published");
        }

        public void Render()
        {
            Console.WriteLine("Document is rendered as Published");
        }
    }
}
