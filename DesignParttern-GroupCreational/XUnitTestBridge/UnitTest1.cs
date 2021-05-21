using Bridge.Behavior;
using Bridge.Classes;
using Bridge.Clients;
using System;
using Xunit;

namespace XUnitTestBridge
{
    public class UnitTest1
    {
        [Fact]
        public void TestDesBridge()
        {
            Client client = new Client();

            Abstraction abstraction;
    
            abstraction = new Abstraction(new ConcreteImplementationA());
            var resultAb = client.ClientCode(abstraction);
            Assert.Equal("Abstract: Base operation with:\nConcreteImplementationA: The result in platform A.\n", resultAb);

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            var resultB = client.ClientCode(abstraction);
            Assert.Equal("ExtendedAbstraction: Extended operation with:\nConcreteImplementationA: The result in platform B.\n", resultB);
        }
    }
}
