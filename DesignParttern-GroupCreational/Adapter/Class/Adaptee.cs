using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.ClassImp
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
