﻿using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Classes
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
            base._implementation.OperationImplementation();
        }
    }
}
