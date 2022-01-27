﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StudentProgram
    {
        int RollNo;
        string Name;
        string Class;
        int Sem;
        string Branch;
        int sum = 0;
        int avg;
        int[] marks = new int[5];
        public StudentProgram(int rollno, string name,string sclass,int sem,string branch)
        {
            RollNo = rollno;
            Name = name;
            Class = sclass;
            Sem = sem;
            Branch = branch;
        }
        public void DisplayResults()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the sub{0} marks of student :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / 5;
            Console.WriteLine("the average if a student in 5 subjects is:{0}", avg);
            for(int i=0;i<5;i++)
            {
                if(marks[i]<35)
                {
                    Console.WriteLine("student result is failed");
                }
                else if((marks[i]>35)&&(avg < 50))
                {
                    Console.WriteLine("student result is failed");
                }
                else
                {
                    Console.WriteLine("student result is passed");
                }
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("the student details are:");
            Console.WriteLine("rollno:" + RollNo + "\n" + "Name:+" + Name + "\n" + "class:" + Class + "\n" + "semister" + Sem + "\n" + "branch: " + Branch);
            DisplayResults();
        }
        static void Main()
        {
            StudentProgram st = new StudentProgram(204, "praveen", "btech", 8, "cse");
            st.DisplayData();
            Console.ReadLine();
        }
    }
}
