using System;

namespace Behavior{
    class RestoreDesinfection: IDesinfectionStrategy{
        private string _lastVersionInstalled;
        public void desinfectFile(File file){
            setLastVersionInstalled(file);
            Console.WriteLine($"Restoring to a last version...");
            Console.WriteLine($"Restored to {_lastVersionInstalled} version.");
            file._threats.Clear();
        }
        public void setLastVersionInstalled(File file){
            _lastVersionInstalled = file._lastVersionInstalled;
        }
    }
}