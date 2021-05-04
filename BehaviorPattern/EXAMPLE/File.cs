using System;
using System.Collections.Generic;

namespace Behavior{
    public class File{
        public string _name;
        public string _path;
        public int _amountCodeLines;
        public string _lastVersionInstalled;
        public string _replacementFilePath;
        public List<string> _threats;
        public File(string name, string path, int amountCodeLines, string lastVersionInstalled, string replacementFilePath){
            _name = name;
            _path = path;
            _amountCodeLines = amountCodeLines;
            _lastVersionInstalled = lastVersionInstalled;
            _replacementFilePath = replacementFilePath;
        }
    }
}