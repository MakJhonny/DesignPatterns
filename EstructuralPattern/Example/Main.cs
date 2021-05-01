using System;

namespace Estructural
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationProgram word2010 = new TextEditor("Microsoft Word",56,ProgrammingLanguage.CPlusPlus);
            ApplicationProgram firefox = new Browser("Mozila Firefox Browser",12,ProgrammingLanguage.C);

            IOperativeSystem windows7 = new WindowsBasedOS();
            IOperativeSystem linuxV20 = new UnixBasedOS();

            firefox._launcher = linuxV20;
            word2010._launcher = windows7;

            firefox.launch();
            word2010.launch();
        }
    }
}
