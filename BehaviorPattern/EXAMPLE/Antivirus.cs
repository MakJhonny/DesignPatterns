using System;
using System.Collections.Generic;

namespace Behavior{
    class Antivirus{
        private string _name;
        private IDesinfectionStrategy _desinfectionStrategy;

        public Antivirus(string name, IDesinfectionStrategy desinfectionStrategy){
            _name = name;
            _desinfectionStrategy = desinfectionStrategy;
        }
        public void analyseFile(File file){
            Console.WriteLine($"{_name} has start the analyse process.");
            Console.WriteLine($"Locating file {file._name} in {file._path}...");
            
            List<string> threats = new List<string>{};
            for(int numberLine=1; numberLine <= file._amountCodeLines; numberLine++){
                Console.WriteLine($"Analysing line {numberLine}/{file._amountCodeLines}...");

                Random rdm = new Random();
                if(rdm.Next(1,10)<=3){
                    threats.Add($"section {numberLine} corrupted");
                }
            }
            file._threats = threats;
            Console.WriteLine($"Analysis Completed");
            Console.WriteLine($"{threats.Count} threats found!");
        }
        public void solveThreats(File file){
            desinfectFile(file);
            Console.WriteLine("Threats solved, desinfection completed.");
            Console.WriteLine();
        }
        public void desinfectFile(File file){
            Console.WriteLine($"Desinfecting {file._name}...");
            _desinfectionStrategy.desinfectFile(file);
        }
    }
}