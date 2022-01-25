using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SmallAndLarge
    {
        public static void Main()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            String s1 = (a > b && a > c ? "a is greater" : b > c ? "b is greater" : "c is greater");
            Console.WriteLine(s1);
        }
    }
}
