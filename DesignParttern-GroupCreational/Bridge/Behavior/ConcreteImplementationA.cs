using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Behavior
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
