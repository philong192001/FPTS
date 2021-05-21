using Adapter.AdapterImp;
using Adapter.ClassImp;
using Adapter.Interface;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
                Adaptee adaptee = new Adaptee();
                ITarget target = new Adapterr(adaptee);

                Console.WriteLine("Adaptee interface is incompatible with the client.");
                Console.WriteLine("But with adapter client can call it's method.");

                Console.WriteLine(target.GetRequest());
        }

        //Adapter Pattern : là 1 trong những Pattern thuộc nhóm cấu trúc (Structural Pattern).
        //Adapter Pattern cho phép các inteface (giao diện) không liên quan tới nhau có thể làm việc cùng nhau. Đối tượng giúp kết nối các interface gọi là Adapter.

        //Adapter Pattern giữ vai trò trung gian giữa hai lớp, chuyển đổi interface của một hay nhiều lớp có sẵn thành một interface khác, thích hợp cho lớp đang viết.
        //Điều này cho phép các lớp có các interface khác nhau có thể dễ dàng giao tiếp tốt với nhau thông qua interface trung gian, không cần thay đổi code của lớp có sẵn cũng như lớp đang viết.

        //Cẩu trúc 
        //1. Adaptee: định nghĩa interface không tương thích, cần được tích hợp vào.
        //2. Adapter: lớp tích hợp, giúp interface không tương thích tích hợp được với interface đang làm việc. Thực hiện việc chuyển đổi interface cho Adaptee và kết nối Adaptee với Client
        //3. ITarget: một interface chứa các chức năng được sử dụng bởi Client (domain specific).
    }
}
