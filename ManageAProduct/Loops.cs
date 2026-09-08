using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAProduct
{
    internal class Loops
    {
        public static void for_Loop()
        {
            int quantity;
            Console.Write("Nhập số lượng: ");
            bool isQuantity = int.TryParse(Console.ReadLine(), out quantity);

            if (isQuantity)
            {
                for(int i = quantity; i <= 5; i++)
                {
                    Console.WriteLine($"Sản phẩm {i}");
                }
            }
            else
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ!");
            }  
        }

        public static void for_Loop2()
        {
            int quantity;
            Console.Write("Nhập số lượng: ");
            bool isQuantity = int.TryParse(Console.ReadLine(), out quantity);

            if(isQuantity)
            {
                for(int i = 1; i <= quantity; i++)
                {
                    Console.WriteLine($"Sản phẩm {i}");
                }
            }
            else
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ!");
            }
        }
    }
}
