﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StringCompare
    {
        static void Main()
        {
            string str, str1;
            Console.WriteLine("enter the string : ");
            str = Console.ReadLine();
            Console.WriteLine("enter the second string : ");
            str1 = Console.ReadLine();
            if(str==str1)
            {
                Console.WriteLine("given strings are same");
            }
            else
            {
                Console.WriteLine("strings are not equal");
            }
            Console.ReadLine();
        }
    }
}
