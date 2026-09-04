using System.Diagnostics;
using System.Text;

namespace ManageAProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //manageProduct();      //Method
            //Console.WriteLine();
            //advancedSection();    //Method
            //Console.WriteLine();
            //SayHello("Thiện");    //Method
            //Console.WriteLine();
            //Condition();          //Method
            //Console.WriteLine();
            //advancedCondition();  //Method
            //Console.WriteLine();
            productDiscount();      //Method
        }
        static void manageProduct()
        {
            string productID = "Sp001";
            string nameProduct = "Iphone11";
            int quantity = 27;
            decimal price = 12000000;

            Console.WriteLine($"Mã sản phẩm: {productID}");
            Console.WriteLine($"Tên sản phẩm: {nameProduct}");
            Console.WriteLine($"Số lượng: {quantity}");
            Console.WriteLine($"Giá: {price}");
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
        static void Condition() //Method điều kiện
        {
            Console.Write("Nhập số lượng: ");
            int quantity = int.Parse(Console.ReadLine());
            if (quantity > 0)
            {
                Console.WriteLine($"Còn sản phẩm🎉\nSố lượng: {quantity}");
            }
            else if (quantity == 0)
            {
                Console.WriteLine($"Hết sản phẩm!");
            }
            else
            {
                Console.WriteLine("Số lượng nhập không tồn tại💥");
            }

        }
        static void advancedCondition() // Điều kiện nâng cao
        {
            Console.Write("Nhập giá sản phẩm: ");
            decimal price = decimal.Parse(Console.ReadLine());
            if (price > 0)
            {
                Console.WriteLine("Giá hợp lệ🎊");
            }
            else if (price == 0)
            {
                Console.WriteLine("Giá phải lớn hơn 0!");
            }
            else
            {
                Console.WriteLine("Giá không hợp lệ!");
            }
        }
        static void productDiscount() //Giảm giá sản phẩm
        {
            Console.Write("Nhập giá sản phẩm: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng sản phẩm: ");
            int quantity = int.Parse(Console.ReadLine());
            double discount = 0.1;

            if (price >= 1000000 && quantity >= 10)
            {
                double finalPrice = price - (price * discount);
                Console.WriteLine($"Sản phẩm được giảm 10%\nGiá sau khi giảm: {finalPrice}");
            }
            else
            {
                Console.WriteLine("Không giảm giá!");
            }
        }
    }
}
