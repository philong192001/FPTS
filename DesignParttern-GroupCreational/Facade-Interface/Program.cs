using Facade_Interface.Facade;
using System;

namespace Facade_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            //var a = facadeForClient.GetVegPizza();
            //Console.WriteLine("Call"+a);
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}
