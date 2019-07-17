using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.

namespace EulerProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            long SumOfMultipleThree = 0;
            long SumOfMultipleFive = 0;

            for(int i = 1; i < 200; i++)
            {
                SumOfMultipleFive += (5 * i);
            }
            for (int i = 1; i <= 333; i++)
            {
                if ((i % 5) != 0)
                {
                    SumOfMultipleThree += (3 * i);
                }
            }
            Console.WriteLine((SumOfMultipleFive + SumOfMultipleThree).ToString());
            Console.ReadLine();
            }

        }
    }

