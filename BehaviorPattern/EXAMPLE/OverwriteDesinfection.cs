using System;

namespace Behavior{
    class OverwriteDesinfection: IDesinfectionStrategy{
        private string _newFilePath;
        public void desinfectFile(File file){
            setFileToReplace(file);
            Console.WriteLine($"Getting file from {file._replacementFilePath}..");
            Console.WriteLine($"Replacing file...");
            file._threats.Clear();
        }
        public void setFileToReplace(File file){
            _newFilePath = file._replacementFilePath;
        }
    }
}