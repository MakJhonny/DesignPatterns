using System;

namespace Estructural{
    class TextEditor: ApplicationProgram{
        private int _maxLinesSupported;
        private int _linesWritted;
        public TextEditor(string name, int size, ProgrammingLanguage baseLanguage)
            :base(name, size, baseLanguage)
        {
            _maxLinesSupported = 10000;
            _linesWritted = 0;
        }
        public override void launch()
        {
            int launchingTime = _launcher.launchProgram(_name, _baseLanguage);
            Console.WriteLine($"Launching time {launchingTime} ms.");
            Console.WriteLine($"The {_name} text editor is running");
            Console.WriteLine($"Writted {_linesWritted} lines of {_maxLinesSupported} supported.");
            Console.WriteLine();
        }
    }
}