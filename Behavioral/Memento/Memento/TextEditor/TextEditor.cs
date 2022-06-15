using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class TextEditor : IOriginator
    {
        private string _text = "";
        private int _cursorPosition = 0;


        public IMemento MakeSnapshot()
        {
            return new Snapshot(this, _text, _cursorPosition);
        }

        public void SetState(string text, int cursor_position)
        {
            _text = text;
            _cursorPosition = cursor_position;
        }


        public string GetCurrentTextAndCoursorIndex()
        {
            return "Text '" + _text + "' Cursor: '" + _cursorPosition + "'";
        }
    }
}
