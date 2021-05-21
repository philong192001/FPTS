using Facade_Interface.Interface;
using Facade_Interface.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Interface.Facade
{
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }
        public string GetNonVegPizza()
        {
            return _PizzaProvider.GetNonVegPizza();
        }
        public string GetVegPizza()
        {
            return _PizzaProvider.GetVegPizza();
        }
        public string GetGarlicBread()
        {
            return _BreadProvider.GetGarlicBread();
        }
        public string GetCheesyGarlicBread()
        {
            return _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
