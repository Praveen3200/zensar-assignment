﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2

{
    abstract class StudentPro
    {
        public string Name;
        public int StudentId;
        public float Grade;
        abstract public Boolean IsPassed(float grade);
    }
    class Undergraduate : StudentPro
    {
        public override bool IsPassed(float grade)
        {
            Console.WriteLine("enter name of the student : ");
            Name = Console.ReadLine();
            Console.WriteLine("student name:{0}", Name);
            Console.WriteLine("enter student id:");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId:{0}", StudentId);

            if(grade >= 70.0f)
            {

                Console.WriteLine("The grade of Student is:");
                return true;
            }
            else
            {
                Console.WriteLine("the grade of Student is:");
                return false;
            }
        }
       
    }
    class Graduate : StudentPro
    {
        public override bool IsPassed(float grade)
        {
            Console.WriteLine("enter name of the student : ");
            Name = Console.ReadLine();
            Console.WriteLine("student name:{0}", Name);
            Console.WriteLine("enter student id:");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId:{0}", StudentId);

            if (grade >= 80.0f)
            {

                Console.WriteLine("The grade of Student is:");
                return true;
            }
            else
            {
                Console.WriteLine("the grade of Student is:");
                return false;
            }
        }
    }
    class student
    {
        static void Main()
        {
            Undergraduate ug = new Undergraduate();
            Console.WriteLine(ug.IsPassed(55.0f));
            Graduate g = new Graduate();
            Console.WriteLine(g.IsPassed(85.0f));
            Console.Read();
        }
    }
}
