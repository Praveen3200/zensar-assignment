using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
        struct Employee_3
        {
            public string EmpName;
            public Employee_4 e;
        }
        struct Employee_4
        {
            public int day;
            public int month;
            public int year;

        }
        class StructEmployee
        {
            static void Main()
            {
                Employee_3[] emp = new Employee_3[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Name of the Employee:");
                    emp[i].EmpName = Console.ReadLine();
                    Console.WriteLine("Day of Birth: ");
                    emp[i].e.day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Month of Birth: ");
                    emp[i].e.month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Year of Birth: ");
                    emp[i].e.year = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Name of the Employee:{0}\nDay of Birth: {1}\nMonth of the Birth: {2}\nYear of the birth: {3}\n", emp[i].EmpName, emp[i].e.day, emp[i].e.month, emp[i].e.year);
                    //Console.WriteLine("");
                }
                Console.Read();

            }
        }
}
