using Adapter.ClassImp;
using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AdapterImp
{
    //Class Apdapter kế thừa interface ITarget và khởi tạo class Adapter trong constructor để sử dụng chung trong class Adapter
    public class Adapterr : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapterr(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
