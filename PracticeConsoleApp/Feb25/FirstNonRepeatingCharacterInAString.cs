using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Feb25
{
    internal class FirstNonRepeatingCharacterInAString
    {
        public char Find(string str)
        {
            char returnChar = '\0';
            for (int i = 0; i < str.Length; i++)
            {
                returnChar = str[i];
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (returnChar == str[j])
                    {
                        count++;
                    }
                    if (count == 1 && j == str.Length - 1)
                    {
                        return returnChar;
                    }
                }
            }
            return '\0';
        }

        public char? FindUsingDictionary(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c]++;
                }
            }

            // Can also use this linq statement to return result
            //return dict.Where(x => x.Value == 1).Select(x => x.Key).FirstOrDefault();

            foreach (char c in dict.Keys)
            {
                if (dict[c] == 1) return c;
            }
            return null;
        }
    }
}
