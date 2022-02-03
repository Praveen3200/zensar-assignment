//2.. Create a Class called Products with Productid, Product Name, Price.
//Accept 10 Products, sort them based on the price, and display the sorted Products
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Product
    {

        static void Main()
        {
            int ProductID;
            string ProductName;
            SortedList<double, string> product = new SortedList<double, string>();
            Console.WriteLine("Enter 10 Products Details:");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Enter product {0} Price and Product {1} Name", i + 1, i + 1);
                product.Add(Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            }
            Console.WriteLine("After sorting the deatils of products are:");
            foreach (KeyValuePair<double, string> prod in product)
            {
                Console.WriteLine("Product Name: {1} \t ProductName: {0}", prod.Key, prod.Value);
            }
            Console.Read();
        }
    }
}
