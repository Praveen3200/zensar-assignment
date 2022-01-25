using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AscDescOrder
    {
        static void Main()
        {
            int total = 0;
            float avg;
            int[] arr = new int[10];
            Console.WriteLine("enter marks: ");
            for(int i= 0;i<10;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Min:{0}\nMax:{1}", arr[0], arr[9]);
            Console.WriteLine("Array in ascending order : ");
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(arr);
            Console.WriteLine("array in descending order : ");
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            for(int i =0;i <10;i++)
            {
                total += arr[i];
            }
            Console.WriteLine("total:{0}", total);
            avg = (float)total / 10;
            Console.WriteLine("Average:{0}", avg);
            Console.Read();
        }
    }
}
