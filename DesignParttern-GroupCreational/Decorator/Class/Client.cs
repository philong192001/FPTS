using Decorator.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Class
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public string ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
            return "RESULT: " + component.Operation();
        }
    }
}
