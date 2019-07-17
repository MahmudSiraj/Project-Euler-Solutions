using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblemSix
{
    class Program
    {
        static void sumSqaure(int n)
        {
            long sumOfSquares= 0;
            long sqaureOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i*i);
                sqaureOfSum += i;
            }
            sqaureOfSum *= sqaureOfSum;
            Console.WriteLine("Sum of Sqaures:" + sumOfSquares.ToString());
            Console.WriteLine("Square of Sum: " + sqaureOfSum.ToString());
            Console.WriteLine("Difference: " + (sqaureOfSum-sumOfSquares).ToString());

        }
        static void Main(string[] args)
        {
            sumSqaure(100);
            Console.ReadLine();
        }
    }
}
