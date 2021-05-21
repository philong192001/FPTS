using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Behavior
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}
