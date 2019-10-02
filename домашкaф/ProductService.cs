using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace домашкaф
{
    class ProductService

    {
        private int _count = 1;

        public List<Product> Products { get; set; } = new List<Product>();


        public List<Product> GetProducts()
        {
            return Products;
        }

        public void AddProducts(Product product)
        {
            product.Id = _count++;
            Products.Add(product);
        }

        public void SortByName()
        {

            var result = from product in Products
                         orderby product.Name
                         select product;

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
        }

        public void UpdateProduct(int id, Product product)
        {

            Products[id].Name = product.Name;
            Products[id].Price = product.Price;
        }
    }



}


