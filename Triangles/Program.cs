using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("enter the 3 lenghts of you triangle");
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                int C = int.Parse(Console.ReadLine());

                if(A >= B + C || B >= A + C || C >= A +B)
                {
                    Console.WriteLine("Not A triangle");
                }
                else if(A == B && B == C && A == C)
                {
                    Console.WriteLine("Your Triangle is Equilateral");
                }
                else if(A == B || B == C || A == C)
                {
                    Console.WriteLine("Your Triangle is isoscelen");
                }
                else
                {
                    Console.WriteLine("Your Triangle is scalene");
                }
            }
            
        }
    }
}
