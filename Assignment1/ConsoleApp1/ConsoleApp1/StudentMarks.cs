using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentMarks
    {
        public static void Main()
        {
            string name;
            float html, csharp, sql, avg, sum;
            int sub = 3;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter name of student :");
                name = Console.ReadLine();
                Console.WriteLine("enter html marks :");
                html = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter csharp marks :");
                csharp = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter sql marks :");
                sql = Convert.ToSingle(Console.ReadLine());
                sum = html + csharp + sql;
                avg = sum / sub;
                if(avg>50)
                {
                    Console.WriteLine("passed");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
        }
    }
}
