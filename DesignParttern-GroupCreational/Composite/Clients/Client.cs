using Composite.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Clients
{
    public class Client
    {

        public string ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
            return $"RESULT: {leaf.Operation()}";
        }


        public string ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");

            return $"RESULT: {component1.Operation()}";
        }
    }
}
