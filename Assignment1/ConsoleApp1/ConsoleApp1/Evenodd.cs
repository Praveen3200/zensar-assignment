using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Evenodd
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("enter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"number {n} is even", n);
            }
            else
            {
                Console.ReadLine($" number {n} is odd", n);
            }
            Console.ReadLine();
        }
    }
}
