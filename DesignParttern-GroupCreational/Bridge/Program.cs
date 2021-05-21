using Bridge.Behavior;
using Bridge.Classes;
using Bridge.Clients;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }

    //Công dụng : 
    //1. Giảm sự phục thuộc giữa abstraction và implementation (loose coupling)
    //2. Giảm số lượng những lớp con không cần thiết
    //3. Code sẽ gọn gàng hơn và kích thước ứng dụng sẽ nhỏ hơn
    //4. Dễ bảo trì hơn: các Abstraction và Implementation của nó sẽ dễ dàng thay đổi lúc runtime cũng như khi cần thay đổi thêm bớt trong tương lai.
    //5. Dễ dàng mở rộng về sau
    //6. Cho phép ẩn các chi tiết implement từ client

    //Cấu trúc : 
    //1. Abstraction : Định nghĩa Interface của lớp trừu tượng,Refer tới object có kiểu là Implementor
    //2. ExtendedAbstraction : Kế thừa Abstraction
    //3. IImplementation : Định nghĩa interface của object chứa các method cần gọi từ Abstraction
    //4. ConcreteImplementationA and ConcreteImplementationB : Kế thừa IImplementation và định nghĩa chi tiết hàm thực thi
}
