using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternTutorial
{
    public class Notepad
    {
        private string _text;

        public Memento SetText(string text)
        {
            Memento memento = new Memento(_text);
            _text = text;
            return memento;
        }

        public string GetText()
        {
            return _text;
        }

        public void Undo(Memento previousState)
        {
            _text = previousState.GetText();
        }
    }
}
