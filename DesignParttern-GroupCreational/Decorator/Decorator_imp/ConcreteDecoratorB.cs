using Decorator.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator_imp
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    public class ConcreteDecoratorB : Decorators
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
