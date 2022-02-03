//1. Write a program to find the Sum and the Average points scored by the teams in the IPL.
//Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches),
//that takes no.of matches as input and accepts that many scores from the user.
//The function should then display the Average and Sum of the scores
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Cricket
    {
        int sum = 0, avg;

        public void PointsCalculation(int no_of_matches)
        {
            int[] Score = new int[20];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter Match{0} score :", i + 1);
                Score[i] = Convert.ToInt32(Console.ReadLine());
                sum += Score[i];
            }
            avg = sum / no_of_matches;
            Console.WriteLine("Sum:{0} and Avg:{1} for IPL Scores in {2} matches!!", sum, avg, no_of_matches);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Cricket c = new Cricket();
            Console.WriteLine("Enter no of matches:");
            x = Convert.ToInt32(Console.ReadLine());
            c.PointsCalculation(x);
            Console.Read();
        }
    }
}
//Output:
//Enter no of matches:
//3
//Enter Match1 score :
//90
//Enter Match2 score :
//60
//Enter Match3 score :
//50
//Sum: 200 and Avg:66 for IPL Scores in 3 matches!!