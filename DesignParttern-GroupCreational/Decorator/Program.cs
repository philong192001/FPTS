using Decorator.Class;
using Decorator.Decorator_imp;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }

    //Công dụng Decorator Parttern -> Cần sử dụng Decorator khi muốn mở rộng obj ở Runtime
    //1. Có thể bổ sung decorator cho obj
    //2. Obj gốc không thay đổi và không biết gì về những thứ được bổ sung cho nó
    //3. Cần instance 1 class riêng với mọi thứ bên trong
    //4. Các obj decorator là độc lập và có thể extends và imp nhau

    //Thiết kế , cấu trúc 
    //1. Component : class gốc (class cha)
    //2. Decorator : class decorator (class con) đã kế thừa từ Component và có các func mới 
    //Cả Component và Decorator đều phải extends 1 interface IComponent hoặc 1 Abstract Class
    //3. SetComponent là func và method riêng của Decorator bổ sung cho obj gốc (của Component)
    //4. Operation : Decorator không chỉ bổ sung mà còn thay thế method của clas gốc. 
    // -> Nếu cần thay thế, cần được chỉ rõ trong giao diện chung giữa Component và Decorator (using override)

    //Giữa Decorator và IComponent có thêm quan hệ aggregate (has-a), thể hiện qua biến private Component kiểu IComponent bên trong Decorator ( protected Component _component;)
    // Gần giống với tạo ra 1 case extends trong OOP (1 obj đã được mở rộng có thể tiếp tục mở rộng các func bởi 1 decorator khác)
}
