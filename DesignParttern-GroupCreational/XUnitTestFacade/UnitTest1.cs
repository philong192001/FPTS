using Facade_Interface.Facade;
using System;
using Xunit;

namespace XUnitTestFacade
{
    public class UnitTest1
    {
        [Fact]
        public void TestFacade()
        {
                RestaurantFacade facade = new RestaurantFacade();
                string a = facade.GetVegPizza();
                //string b = facade.GetCheesyGarlicBread();
                //string c = facade.GetGarlicBread();
                Assert.Equal("Getting Veg Pizza.", a);
                //Assert.Equal("Getting Garlic Bread.", b);
                //Assert.Equal("Getting Cheesy Garlic Bread.", c);
                
        }

        //false
        [Fact]
        public void TestFacede1()
        {
            RestaurantFacade facade = new RestaurantFacade();
            string b = facade.GetCheesyGarlicBread();
            Assert.Equal("Getting Garlic Bread....", b);
        }
    }
}
