﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StringLen
    {
        static void Main(string[] args)
        {
            string str;
            int length;
            Console.WriteLine("enter the string: ");
            str = Console.ReadLine();
            length = str.Length;
            Console.WriteLine("the given string length is :{0}", length);
            Console.ReadLine();
        }
    }
}
