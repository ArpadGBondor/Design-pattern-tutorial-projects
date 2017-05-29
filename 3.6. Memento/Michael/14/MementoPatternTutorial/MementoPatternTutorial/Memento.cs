using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternTutorial
{
    public class Memento
    {
        private string _text;

        public Memento(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
