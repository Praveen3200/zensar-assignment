using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
    struct Employee_1
    {
        public string EmpName;
        public Employee_2 e;
    }
    struct Employee_2
    {
        public int day;
        public int month;
        public int year;
    }
    class employee
    {
        static void main()
        {
            Employee_1[] emp = new Employee_1[2];
            for(int i =0; i<emp.Length;i++)
            {
                Console.WriteLine("name of the employee:");
                emp[i].EmpName = Console.ReadLine();
                Console.WriteLine("day of birth:");
                emp[i].e.day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("month of birth:");
                emp[i].e.month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("year of birth:");
                emp[i].e.year = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("name of the employee:{0}\nDay of birth:{1}\nMonth of the birth:{2}\nYear of the birth:{3}\n", emp[i].EmpName, emp[i].e.day, emp[i].e.month, emp[i].e.year);

            }
            Console.Read();

        }
    }
}
