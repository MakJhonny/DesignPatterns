using System;
using System.Collections.Generic;

namespace Creational{
    class AdidasFactory: SportProductFactory{
        public AdidasFactory (string name, string location)
            :base(name, location)
        {

        }
        override public SportProduct makeSportProduct(string model)
        {
            SportProduct product = null;
            model = model.ToLower();
            switch(model){
                case "football boot": 
                    product = new FootballBoot("Predator plus 20", true);
                    product.setQualityRuntime("10 months");
                    return product;
                case "football jersey": 
                    product = new FootballJersey(JerseySize.M, "Germany", 10);
                    product.setQualityRuntime("2 years");
                    return product;
                default: 
                    return null;
            }
        }
    }
}