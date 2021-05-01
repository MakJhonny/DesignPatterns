using System;

namespace Estructural{
    class UnixBasedOS: IOperativeSystem{
        private string _executionCommand;
        public void setExecutionCommand(string command)
        {
            _executionCommand = command;
        }
        public int launchProgram(string fileName, ProgrammingLanguage language){
            setExecutionCommand($"file {fileName}");
            Console.WriteLine("Executig task(s)...");
            Console.WriteLine($"Checking Syntax for {language} program...");
            Console.WriteLine($"Launching {fileName}...");
            Console.WriteLine("Launching has been completed.");
            return 3;
        }
    }
}