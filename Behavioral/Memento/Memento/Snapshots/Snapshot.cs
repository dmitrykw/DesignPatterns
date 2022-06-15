using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Snapshot : IMemento
    {
        private TextEditor _textEditor;
        private DateTime _createdDateTime;

        private string _text;
        private int _cursorPosition;

        public Snapshot(TextEditor text_editor, string curr_text, int cursor_position)
        {
            _textEditor = text_editor;
            _createdDateTime = DateTime.Now;

            _text = curr_text;
            _cursorPosition = cursor_position;
        }

        public DateTime GetSnapshotDate()
        {
            return _createdDateTime;
        }

        public string GetSnapshotTextAndCoursorIndex()
        {
            return _text + " " + _cursorPosition;
        }

        public void Restore()
        {
            _textEditor.SetState(_text, _cursorPosition);
        }
    }
}
