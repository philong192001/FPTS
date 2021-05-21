using Composite.Clients;
using Composite.Composites;
using System;

namespace Composite
{
    public class Program
    {            
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);
            
            Composite_Run tree = new Composite_Run();
            Composite_Run branch1 = new Composite_Run();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite_Run branch2 = new Composite_Run();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }

        //Composite Parttern : Cho phép thực hiện các tương tác với tất cả obj tương tự nhau 
        //Một obj Composite được tạo thành từ một hay nhiều obj tương tự nhau (hoặc có một số chức năng tương tự nhau).
        //Ý tưởng ở đây là có thể thao tác trên một list obj theo cách như thao tác trên một obj duy nhất, các obj của list phải có các thao tác chung (method chung).

        //Công dụng : (Composite có thể được gọi là “Đối tượng đa hợp”)
        //1. Composite là mẫu thiết kế dùng để tạo ra các obj trong các cấu trúc cây để biểu diễn hệ thống phân lớp.
        //2. Composite cho phép các client tác động đến từng obj và các thành phần của obj 1 cách thống nhất.
        //3. Miêu tả cho toàn bộ hệ thống của các đối tượng
        //4. Có thể bỏ qua sự khác biệt giữa thành phần của các đối tượng và các đối tượng cá nhân
        //5. Xử lý tất cả các đối tượng trong cơ cấu Composite chung

        //Cấu trúc : 
        //1. Component : Khai báo interface hoặc abstract chung cho các thành phần obj , Chứa các method thao tác chung của các thành phần obj.
        //2. Leaf : Biểu diễn các obj Leaf (ko có con) trong thành phần đối tượng.
        //3. Composite : Định nghĩa một thao tác cho các thành phần có thành phần con , Lưu trữ thành phần con , Thực thi sự quản lý các thành phần con của IComponent (interface hoặc abstract class).

        //Ưu điểm: 
        //1. Làm cho việc thêm các thành phần trong một cấu trúc tương đồng trở nên dễ dàng.
        //2. Làm cho các client đơn giản hơn, vì không cần phải biết là đang làm việc trên một leaf hoặc một thành phần của Composite.
        // ->  Composite Design chuyên trị những vấn đề có dạng đệ qui, nó làm việc trên các đối tượng abstract, không làm việc với đối tượng cụ thể nên khả năng mở rộng cũng rất cao.

        //Nhược điểm 
        //1. Khó khăn trong việc hạn chế các loại thành phần trong một Composite.

        // ===>>>> Composite Pattern: Tổ chức các đối tượng theo cấu trúc phân cấp dạng cây. Tất cả các đối tượng trong cấu trúc được thao tác một cách thuần nhất như nhau.
    }
}
