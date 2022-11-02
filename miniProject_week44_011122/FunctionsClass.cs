using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProject_week44_011122
{
    internal class FunctionsClass
    {
        public ProductClass NewProduct()
        {
            Console.ResetColor();
            Console.Write("Enter a Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter a Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter a Price: ");
            int price = int.Parse(Console.ReadLine());

            ProductClass product = new ProductClass(category, productName, price);
            return product;

        }

        public void SearchProduct(ProductClass pClass, List<ProductClass> input)
        {
            Console.Write("Enter a product name: ");

        }
    }
}
