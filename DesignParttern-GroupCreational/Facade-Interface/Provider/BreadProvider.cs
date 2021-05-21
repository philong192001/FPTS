using Facade_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Interface.Provider
{
    public class BreadProvider : IBread
    {
        public string GetCheesyGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
            return "Getting Garlic Bread.";
        }

        public string GetGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
            return "Getting Cheesy Garlic Bread.";
        }

        private string GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
            return "Getting Cheese.";
        }
    }
}
