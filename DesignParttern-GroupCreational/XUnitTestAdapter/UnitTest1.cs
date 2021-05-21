using Adapter.AdapterImp;
using Adapter.ClassImp;
using Adapter.Interface;
using System;
using Xunit;

namespace XUnitTestAdapter
{
    public class UnitTest1
    {
        [Fact]
        public void TestDesAdapterByNong()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapterr(adaptee);

            var result = target.GetRequest();

            Assert.Equal("This is 'Specific request.'", result);
        }
    }
}
