using Decorator.Class;
using Decorator.Decorator_imp;
using System;
using Xunit;

namespace XUnitTestDecorator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Client client = new Client();

            var simple = new ConcreteComponent();

            var resultS = client.ClientCode(simple);

            Assert.Equal("RESULT: ConcreteComponent", resultS);

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);

            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);

            var resultD2 =  client.ClientCode(decorator2);

            Assert.Equal("RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))", resultD2);

        }

        [Fact]
        public void Test2()
        {

        }
    }
}
