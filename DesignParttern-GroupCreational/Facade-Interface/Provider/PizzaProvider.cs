using Facade_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Interface.Provider
{
    public class PizzaProvider : IPizza
    {
        public string GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
            return "Getting Non Veg Pizza.";
        }

        public string GetVegPizza()
        {
           Console.WriteLine("Getting Veg Pizza.");
           return "Getting Veg Pizza.";
        }

        private string GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
            return "Getting Non Veg Pizza Toppings.";
        }
    }
}
