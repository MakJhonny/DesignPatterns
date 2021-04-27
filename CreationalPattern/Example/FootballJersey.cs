using System;

namespace Creational{
    public enum JerseySize{
        P, M, G, L, XL, XXL
    }
     class FootballJersey: SportProduct{
        private JerseySize _size;
        private string _team;
        private int _backNumber;
        private string _qualityRuntime;

        public FootballJersey(JerseySize size, string team, int backNumber){
            _size = size;
            _team = team;
            _backNumber = backNumber;
        }

        public string describe(){
            return ($"This Footall jersey from team {_team},  has a size {_size} and a back number {_backNumber}");
        }
        public string getSportFocused(){
            return "Football";
        }
        public void setQualityRuntime(string qualityRuntime){
            _qualityRuntime = qualityRuntime;
        }
    }
}