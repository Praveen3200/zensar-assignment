//3. Create a simple Stationery application to add items and display added items using Generic collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Stationary
    {
        static void Main()
        {
            List<string> S = new List<string>();
            S.Add("Pens");
            S.Add("Chair");
            S.Add("Calculator");
            S.Add("Pencil");
            S.Add("Sharpner");
            S.Add("Books");
            Console.WriteLine("The Added Items are:");
            foreach (var item in S)
            {

                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
//OUTPUT:
//The Added Items are:
//Pens
//Chair
//Calculator
//Pencil
//Sharpner
//Books