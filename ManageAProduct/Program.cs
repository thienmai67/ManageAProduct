using System.Text;

namespace ManageAProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string productID = "Sp001";
            string nameProduct = "Giày đá banh";
            int quantity = 21; //Số lượng
            decimal price = 35000; //Giá

            Console.WriteLine($"Mã sản phẩm: {productID}");
            Console.WriteLine($"Tên sản phẩm: {nameProduct}");
            Console.WriteLine($"Số lượng: {quantity}");
            Console.WriteLine($"Giá: {price}");
            Console.WriteLine();
            advancedSection(); //Method
            SayHello("Thiện"); //Method
        }

        static void advancedSection()  //Phần nâng cao
        {
            Console.WriteLine("==== Quản Lý Sản Phẩm ====");
            Console.Write("Nhập mã sản phẩm: ");
            string productID = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            string nameProduct = Console.ReadLine();
            Console.Write("Nhập số lượng sản phẩm: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("==== Thông Tin Sản Phẩm ====");
            Console.WriteLine($"Mã Sản Phẩm: {productID}");
            Console.WriteLine($"Tên sản phẩm: {nameProduct}");
            Console.WriteLine($"Số lượng sản phẩm: {quantity}");
            Console.WriteLine($"Giá: {price}");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Xin chào {name}!");
        }
    }
}
