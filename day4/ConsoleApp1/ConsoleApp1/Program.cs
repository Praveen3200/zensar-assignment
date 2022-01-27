using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Distance
    {
        int dist;
        //property
        public int Dist
        {
            get { return dist; }
            set { dist = value; }
        }
        public static Distance operator +(Distance d1,Distance d2)
        {
            Distance temp = new Distance();
            temp.dist = d1.dist + d2.dist;
            return temp;
        }
    }
    class OperateOverloade
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1.Dist = 10;
            d2.Dist = 20;
            Distance d3 = d1 + d2;
            Console.WriteLine(d3);
            Console.ReadLine();
        }
    }
}
