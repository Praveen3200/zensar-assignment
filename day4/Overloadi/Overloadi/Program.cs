using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadi
{
    class Shapes
    {
        public virtual void Message(string s)
        {
            Console.WriteLine($"message from shapes class {s}");
        }
    }
    class Square : Shapes
    {
        public override void Message(string s)
        {
            // base.Message(s);
            Console.WriteLine($"Message from square class {s}");
        }
    }
    class Triangle : Shapes
    {
        public override void Message(string s)
        {
            //base.Message(s);
            Console.WriteLine($"message from triangle {s}");
        }
    }
    class Overload
    {
        static void Main(string[] args)
        {
            Shapes s = new Shapes();
            s.Message("shape base");
            s = new Square();
            s.Message("square message");
            s = new Triangle();
            s.Message("triangle");
            Console.Read();
        }
    }
}
