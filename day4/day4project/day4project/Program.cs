using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4project
{
    class Shape
    {
        protected float R, L, B;
        public virtual float Area()
        {
            return 3.14f * R * R;
        }
        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
   
    }
    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("enter radius :");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            Console.WriteLine(base.Area());
            return 3 * R * R;
        }
        public override float Circumference()
        {
            Console.WriteLine("circle circumference: ");
            return 3 * R;
        }
    }
    class Rectangle:Shape
    {
        public void GetLB()
        {
            Console.Write("enter the length:");
            L = float.Parse(Console.ReadLine());
            Console.Write("enter the breadth: ");
            B = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return L * B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle();
            C.GetRadius();
            float area_of_circle = C.Area();
            float circumference_of_circle = C.Circumference();
            Console.ReadLine();

      
        }
    }
}
