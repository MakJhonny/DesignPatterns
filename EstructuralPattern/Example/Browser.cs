using System;

namespace Estructural{
    class Browser: ApplicationProgram{
        private string _defaultSearchPage;
        public Browser(string name, int size, ProgrammingLanguage baseLanguage)
            :base(name, size, baseLanguage)
        {
            _defaultSearchPage = "google.com";
        }
        public override void launch()
        {
            int launchingTime = _launcher.launchProgram(_name, _baseLanguage);
            Console.WriteLine($"Launching time {launchingTime} ms.");
            Console.WriteLine($"The {_name} browser is running");
            Console.WriteLine($"Request send to {_defaultSearchPage} default dearch view");
            Console.WriteLine();
        }
    }
}