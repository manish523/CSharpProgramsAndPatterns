using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class PalindromeNumberCheck
    {
        public void CheckPalindrome()
        {
            Console.Write("Enter number to reverse: ");
            int numberToReverse = Convert.ToInt32(Console.ReadLine());
            int tempOriginal = numberToReverse;
            int remainder, reverse = 0;
            while (numberToReverse > 0)
            {
                remainder = numberToReverse % 10;
                numberToReverse = numberToReverse / 10;
                reverse = reverse * 10 + remainder;
            }

            if (reverse == tempOriginal)
            {
                Console.WriteLine($"The number is palindrome");
            }
            else
            {
                Console.WriteLine($"The number is not palindrome");
            }
        }
    }
}
