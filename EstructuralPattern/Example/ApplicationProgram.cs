using System;

namespace Estructural{
    public enum ProgrammingLanguage{
        C,
        CPlusPlus,
        Java
    }
    abstract class ApplicationProgram{
        public IOperativeSystem _launcher;
        protected string _name;
        protected int _sizeMB;
        protected ProgrammingLanguage _baseLanguage;
        public ApplicationProgram(string name, int size, ProgrammingLanguage baseLanguage){
            _name = name;
            _sizeMB = size;
            _baseLanguage = baseLanguage;
        }
        public abstract void launch();
    }
}