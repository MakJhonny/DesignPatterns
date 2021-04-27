using System;
using System.Collections.Generic;

namespace Creational
{
    class AdidasSportShop{
        private int _id;
        private List<SportProductFactory> _supliers;
        private List<string> _orders;

        public AdidasSportShop(int id){
            _id  = id;
            SportProductFactory adidasSupplier = new AdidasFactory("adidas", "La Paz");
            _supliers = new List<SportProductFactory>{adidasSupplier};
            _orders = new List<string>{};
        }
        public void recieveOrder(string order)
        {
            _orders.Add(order);
        }
        public string deliverOrder()
        {
            var model = _orders[0];
            _orders.RemoveAt(0);
            var product = supplyProduct(model);
            return (product == null)? $"The product with model {model} is non-existent": $"The order was completed, product description: {product.describe()}";        
        }
        public SportProduct supplyProduct(string order)
        {
            SportProduct boot = null;
            foreach(var supplier in _supliers)
            {
                boot = supplier.makeSportProduct(order);
                if(boot != null) break;
            }
            return boot;
        }
    }
}