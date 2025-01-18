using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class SumOfDigitsInNumber
    {
        public SumOfDigitsInNumber()
        {
            Console.WriteLine("Enter your number");
            int num = Int32.Parse(Console.ReadLine()!);
            int numInput = num;
            if (num == 0)
            {
                Console.WriteLine("Please provide valid number!");
                return;
            }

            int remainder = 0, sum = 0;

            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;
                sum = sum + remainder;
            }

            Console.WriteLine("Sum of digits in {0} is : {1}", numInput, sum);
        }
    }
}
