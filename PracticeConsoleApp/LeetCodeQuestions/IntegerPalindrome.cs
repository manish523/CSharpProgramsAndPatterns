using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions
{
    internal class IntegerPalindrome
    {
        public bool isPalindrome(int input)
        {
            int num = input;
            int revNumber = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                revNumber = revNumber * 10 + remainder;
                num = num / 10;
            }
            return revNumber == input;
        }
    }
}
