using Facade_Interface.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;
using Xunit.Sdk;

namespace NUnitTestFacade
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void Test_GetVegPizza()
            {
                Console.WriteLine("123");
                RestaurantFacade facade = new RestaurantFacade();
                string a = facade.GetVegPizza();
                Assert.AreEqual("Getting Veg Pizza.", a);
            }
        
    }
}