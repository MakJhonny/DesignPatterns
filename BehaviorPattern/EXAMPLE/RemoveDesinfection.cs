using System;
using System.Collections.Generic;

namespace Behavior{
    class RemoveDesinfection: IDesinfectionStrategy{
        public void desinfectFile(File file){
            Console.WriteLine($"Deleting {file._threats.Count} malicious code lines.");
            file._threats.Clear();
        }
    }
}