using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace EulerProblemFive
{
    class Program
    {
        static bool isDivisible(int n)
        {
            for(int i = 1; i <= 20; i++)
            {
                if (n % i != 0)
                    return false;
            }
            return true;
            }
        static void Main(string[] args)
        {
            int i = 1;
            while (!isDivisible(i))
                i++;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
