using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class Factorial
    {
        public void GenerateFactorial()
        {
            Console.Write("Please enter the number to calculate the factorial :");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;

            if (num < 0)
            {
                Console.WriteLine("Factorials are not applicable for negetive numbers.");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero factorial is 1");
            }
            else
            {
                for (int i = num; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"{num} factorial is {factorial}");
            }
            Console.ReadLine();
        }
    }
}
