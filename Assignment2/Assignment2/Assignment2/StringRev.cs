﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StringRev
    {
        static void Main()
        {
            string str, rev = " ";
            Console.WriteLine("enter the string you need to reverse: ");
            str = Console.ReadLine();
            int len = str.Length - 1;
            while(len>=0)
            {
                rev = rev + str[len];
                len--;
            }
            Console.WriteLine("String after reversing:{0}", rev);
            Console.ReadLine();
        }
    }
}
