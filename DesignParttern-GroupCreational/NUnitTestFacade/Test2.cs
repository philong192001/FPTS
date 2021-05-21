using Facade_Interface.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestFacade
{
    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void Test_GetVegPizza()
        {
            //Console.WriteLine("123");

            RestaurantFacade facade = new RestaurantFacade();
            string a = facade.GetVegPizza();
            //string a = "Getting Veg Pizza.";
            Assert.AreEqual("Getting Veg Pizza.", a);


        }
    }
}
