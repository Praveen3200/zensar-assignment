using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Temperature
    {
        static void main()
        {
            float Farenheit, Celsius;
            Console.WriteLine("enter the temparature in farenheit :");
            Farenheit = Convert.ToSingle(Console.ReadLine());
            Celsius = (Farenheit - 32) * 5 / 9;
            Console.WriteLine("Converteed celsius temperature is {0}", Celsius);
            Console.ReadLine();
        }
    }
}
