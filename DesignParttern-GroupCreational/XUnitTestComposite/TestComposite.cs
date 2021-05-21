using Composite.Clients;
using Composite.Composites;
using System;
using Xunit;

namespace XUnitTestComposite
{
    public class TestComposite
    {
        [Fact]
        public void TestDesComposite()
        {
            Client client = new Client();

            Leaf leaf = new Leaf();

            var resultLeaf  = client.ClientCode(leaf);

            Assert.Equal("RESULT: Leaf",resultLeaf);

            Composite_Run tree = new Composite_Run();

            Composite_Run branch1 = new Composite_Run();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            Composite_Run branch2 = new Composite_Run();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
           
            var resultTree = client.ClientCode(tree);

            Assert.Equal("RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf))",resultTree);

            string resultTreeAndLeaf = client.ClientCode2(tree, leaf);

            Assert.Equal("RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)",resultTreeAndLeaf);
        }
    }
}
