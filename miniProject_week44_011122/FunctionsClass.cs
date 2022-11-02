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
            try
            {
                Console.ResetColor();
                Console.Write("Enter a Category: ");
                string category = Console.ReadLine().ToLower().Trim();

                Console.Write("Enter a Product Name: ");
                string productName = Console.ReadLine().ToLower().Trim();

                Console.Write("Enter a Price: ");


                int price = int.Parse(Console.ReadLine().Trim());
                ProductClass pr = new ProductClass(category, productName, price);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product added - press enter to continue");

                return pr;

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong, check that you only put in number in price - press enter to continue");
                return null;
            }
      
            
            
        }

        public void SearchProduct(List<ProductClass> product)
        {
            Console.Write("Enter a product name: ");
            string name = Console.ReadLine();

            List<ProductClass> sortedProduct = product.OrderBy(p => p.ProductName.Equals(name)).ToList();
            sortedProduct.Reverse();

            foreach (ProductClass pr in sortedProduct)
            {
                Console.WriteLine("Category: " + pr.Category.PadRight(10) + " Product name: " + pr.ProductName.PadRight(10) + " Price: " + pr.Price);
            }
          

        }

        public int SumOfPice(List<ProductClass> product)
        {
            int sum =  product.Sum(p => p.Price);

            List<ProductClass> sortPrice = product.OrderBy(p => p.Price).ToList();
            foreach (ProductClass pr in sortPrice)
            {
                Console.WriteLine("Category: " + pr.Category.PadRight(10) + " Product name: " + pr.ProductName.PadRight(10) + " Price: " + pr.Price);
            }

            return sum;
        }
    }
}
