using System;
using System.Collections.Generic;
namespace Creational{
     abstract class SportProductFactory{
        private string _name;
        private string _location;
        public SportProductFactory(string name, string location){
            _name = name;
            _location = location;
        }
        abstract public SportProduct makeSportProduct(string model);
    }
}