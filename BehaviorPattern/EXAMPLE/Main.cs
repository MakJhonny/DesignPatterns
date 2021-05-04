using System;

namespace Behavior
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesinfectionStrategy removeCodeCorrupted = new RemoveDesinfection();
            IDesinfectionStrategy restoreFileToLatestVersion = new RestoreDesinfection();
            IDesinfectionStrategy overwriteFile = new OverwriteDesinfection();


            File ludo_game = new File("ludo_game.exe","./users/ProgramFiles/Ludo", 20, "v12.1.2", "./users/ProgramFiles/Ludo/replacementFiles");
            Antivirus avast = new Antivirus("Avast Free Antivirus",removeCodeCorrupted);
            avast.analyseFile(ludo_game);
            avast.solveThreats(ludo_game);

            File logo_maker = new File("logo_maker.exe","./users/ProgramFiles/LogoMaker", 15, "v7.10.1", "./users/ProgramFiles/LogoMaker/replacementFiles");
            Antivirus nod32 = new Antivirus("Eset Npd32 Antivirus",restoreFileToLatestVersion);
            nod32.analyseFile(logo_maker);
            nod32.solveThreats(logo_maker);

            File snipping_tool = new File("snipping_tool.exe","./users/ProgramFiles/snippingTool", 25, "v5.0.3", "./users/ProgramFiles/snippingTool/replacementFiles");
            Antivirus mcafee = new Antivirus("MCafee Antivirus",overwriteFile);
            mcafee.analyseFile(snipping_tool);
            mcafee.solveThreats(snipping_tool);
        }
    }
}
