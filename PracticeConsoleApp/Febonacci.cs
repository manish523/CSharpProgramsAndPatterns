using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class Febonacci
    {
        public void GenerateFibonacciSeries()
        {


            int number, prevNumber =-1, nextNumber = 1;

            Console.WriteLine("Enter number to generate fibonacci: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(":: Febonacci Seriess ::");

            for (int i = 0; i < number; i++)
            {
                int sumNumber = prevNumber + nextNumber;
                Console.WriteLine(sumNumber);
                prevNumber = nextNumber;
                nextNumber = sumNumber;
            }

        }
    }
}
