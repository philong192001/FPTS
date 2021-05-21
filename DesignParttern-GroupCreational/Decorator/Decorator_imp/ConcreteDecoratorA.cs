using Decorator.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator_imp
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    public class ConcreteDecoratorA : Decorators
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
