using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашкaф
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            Menu menu = new Menu(productService);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить продукт.");
                Console.WriteLine("2. Просмотр меню.");
                Console.WriteLine("3. Сортировка");
                Console.WriteLine("4. Редактирование продуктов");
                Console.WriteLine("5. Выход");

                string position = Console.ReadLine();

                if (position == "1")
                {
                    menu.AddProduct();
                }

                else if (position == "2")
                {
                    menu.ShowProductInfo();
                }

                else if (position == "3")
                {
                    menu.SortByName();
                }

                else if (position == "4")
                {
                    menu.UpdateProduct();
                }

                else if (position == "5")
                {
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Такого варианта не существует");
                    Console.WriteLine("Нажмите Enter чтобы продолжить");
                    Console.ReadKey();
                }


            }








        }

    }
}
