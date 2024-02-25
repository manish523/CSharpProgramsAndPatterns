using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class PrimeNumber
    {
        public PrimeNumber(int number)
        {
            int n = number, a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }

        public static void GeneratePrimeNumberSeries()
        {
            Console.WriteLine("Enter max number for prime number series");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            bool isPrimeNumber = true;

            for (int i = 2; i < maxNumber; i++)
            {
                for (int k = 2; k < maxNumber; k++)
                {
                    if (i != k && i % k == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }
                isPrimeNumber = true;
            }


        }
    }
}
