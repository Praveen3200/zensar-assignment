using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaxArray
    {
        static void Main()
        {
            int sum = 0;
            int avg, n, min, max;
            Console.WriteLine("enter noof elements in an array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array elements are :");
            int[] arr = new int[20];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            avg = sum / n;
            Console.WriteLine("avg of array elements is:{0}", avg);
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("max value in array:{0}", max);
            Console.WriteLine("min value in array:{0}", min);
            Console.ReadLine();
        }
    }
}
