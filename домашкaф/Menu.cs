using System;
using System.Collections.Generic;
using System.Text;

namespace домашкaф
{
    class Menu
    {
        private ProductService _productService;

        public Menu(ProductService productService)
        {
            _productService = productService;
        }

        private string CheckNullString(string text)
        {
            while (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Ошибка ввода!");
                Console.WriteLine("Введите снова!");
                text = Console.ReadLine();
            }

            return text;
        }

        public void AddProduct()
        {
            try
            {

                Console.Clear();

                Product product = new Product();

                Console.WriteLine("Введите название продукта: ");
                product.Name = Console.ReadLine();

                Console.WriteLine("Введите цену продукта");
                product.Price = Convert.ToInt32(Console.ReadLine());

                _productService.AddProducts(product);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exception.Message);
            }
            catch (OverflowException exeption)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exeption.Message);
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exeption.Message);
            }
            Console.WriteLine("Нажмите Enter чтобы продолжить");

            Console.ReadLine();

        }
        public void ShowProductInfo()
        {
            Console.Clear();

            var productlist = _productService.GetProducts();

            foreach (var item in productlist)
            {
                Console.WriteLine("\n" + "Название" + item.Name);
                Console.WriteLine("Цена: " + item.Price);
                Console.WriteLine($"ID продукта: " + item.Id);
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить");

            Console.ReadLine();
        }

        public void SortByName()
        {
            Console.Clear();
            _productService.SortByName();
            Console.WriteLine("Нажмите Enter чтобы продолжить");
            Console.ReadKey();
        }

        public void UpdateProduct()
        {
            try
            {
                Product product = new Product();
                Console.Clear();
                Console.WriteLine("Введите ID продукта");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите новое название");
                product.Name = Console.ReadLine();
                Console.WriteLine("Введите новую цену");
                product.Price = Convert.ToInt32(Console.ReadLine());
                _productService.UpdateProduct(id, product);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exception.Message);
            }
            catch (OverflowException exeption)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exeption.Message);
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exeption.Message);
            }
            Console.ReadKey();

        }

    }
}
