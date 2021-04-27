using System;

namespace Creational{

    class FootballBoot: SportProduct{
        private string _model;
        private bool _noLaces;
        private string _qualityRuntime;

        public FootballBoot(string model, bool noLaces){
            _model = model;
            _noLaces = noLaces;
        }

        public string describe(){
            var lacesMessage = (_noLaces)?"does not":"";
            return($"This Footall boot with model {_model}, {lacesMessage} include laces and it is expected that keeps its quality for {_qualityRuntime} ");
        }
        public string getSportFocused(){
            return "Football";
        }
        public void setQualityRuntime(string qualityRuntime){
            _qualityRuntime = qualityRuntime;
        }
    }
}