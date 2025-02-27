using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    public class StringPalindrome
    {
        public bool CheckPalindrome(string input)
        {
            string rev = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                rev += input[i];
            }

            if (input == rev)
            {
                return true;
            }

            return false;
        }

        public bool IsPalindrome(string input)
        {
            int start = 0, end = input.Length - 1;
            while (start < end)
            {
                if (input[start] != input[end])
                    return false;
                start++;
                end--;

            }
            return true;
        }
    }
}
