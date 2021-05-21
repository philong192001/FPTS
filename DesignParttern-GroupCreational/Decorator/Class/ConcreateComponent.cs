using Decorator.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Class
{

    //Concrete Components provide default implementations of the operations.
    //There might be several variations of these classes.(Có thể thêm các function trong lớp  ConcreteComponent này)
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
