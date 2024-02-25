using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.Write("Enter number to reverse: ");
            int numberToReverse = Convert.ToInt32(Console.ReadLine());
            int remainder, reverse = 0;
            while (numberToReverse > 0)
            {
                remainder = numberToReverse % 10;
                numberToReverse = numberToReverse / 10;
                reverse = reverse * 10 + remainder;
            }

            Console.WriteLine($"The reverse number is {reverse}");
        }
    }
}
