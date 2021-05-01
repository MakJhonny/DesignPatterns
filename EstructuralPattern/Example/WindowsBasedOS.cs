using System;

namespace Estructural{
    class WindowsBasedOS: IOperativeSystem{
        private string _exeFileLocation;
        public WindowsBasedOS(){}
        public void setExeFileLocation(string exeLocation){
            _exeFileLocation = exeLocation;
        }
        public int launchProgram(string fileName, ProgrammingLanguage language){
            setExeFileLocation($"./Programfiles/{fileName}/{fileName}.exe");
            Console.WriteLine($"locating {_exeFileLocation}...");
            Console.WriteLine($"initializating processes in {language} settings...");
            Console.WriteLine($"in execution...");
            Console.WriteLine($"disposing memory space...");
            Console.WriteLine($"launching ended.");
            return 5;
        }
    }
}