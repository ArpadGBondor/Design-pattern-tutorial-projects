using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternTutorial
{
    class Program
    {
        // CARETAKER
        static void Main(string[] args)
        {
            IList<Memento> undos = new List<Memento>();

            Notepad notepad = new Notepad();
            Memento undo;

            // First change
            undo = notepad.SetText("cool");
            undos.Add(undo);

            Console.WriteLine("---EDIT----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Second change
            undo = notepad.SetText(" - Hello there! - General Kenobi.");
            undos.Add(undo);

            Console.WriteLine("---EDIT----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Second change
            undo = notepad.SetText("BAD WOLF");
            undos.Add(undo);

            Console.WriteLine("---EDIT----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Undo
            undo = undos[undos.Count - 1];
            notepad.Undo(undo);
            undos.Remove(undo);
            Console.WriteLine("---UNDO----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Undo
            undo = undos[undos.Count - 1];
            notepad.Undo(undo);
            undos.Remove(undo);
            Console.WriteLine("---UNDO----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            // Undo
            undo = undos[undos.Count - 1];
            notepad.Undo(undo);
            undos.Remove(undo);
            Console.WriteLine("---UNDO----");
            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            Console.ReadKey();
        }
    }
}
