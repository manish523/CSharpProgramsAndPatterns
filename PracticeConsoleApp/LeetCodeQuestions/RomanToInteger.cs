using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions
{
    public static class RomanToInteger
    {

        public static int RomanToInt(string s)
        {
            int inputLength = s.Length;
            int result = 0;

            // Step 1 Create roman map dictionalry
            Dictionary<Char, int> romanMap = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            // Step 2 Loop through each roman character in string
            for (int i = 0; i < inputLength; i++)
            {
                // Step 3 Check if next character exists and if it's greater or lesser then next value
                if (i < inputLength - 1 && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    // Subtract the current value if it's smaller than the next
                    result -= romanMap[s[i]];
                }
                else
                {
                    // Otherwise, add the current value
                    result += romanMap[s[i]];
                }
            }

            return result;


        }
    }
}
