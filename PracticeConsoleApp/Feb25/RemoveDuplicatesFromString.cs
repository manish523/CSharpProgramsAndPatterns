using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Feb25
{
    internal class RemoveDuplicatesFromString
    {
        public string ManualRemoval(string str)
        {
            bool[] seen = new bool[256]; // ASCII character set
            char[] result = new char[str.Length];
            int index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!seen[c])// check if character is already seen
                {
                    seen[c] = true;
                    result[index++] = c;
                }
            }
            return new string(result, 0, index);
        }

        public string RemoveDuplicatesUsingHashSet(string str)
        {
            HashSet<char> seen = new HashSet<char>();
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        public string RemoveDuplicatesUsingStringBuilder(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!result.ToString().Contains(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        public string RemoveDuplicatesUsingDictionary(string str)
        {
            Dictionary<char, bool> seen = new Dictionary<char, bool>();
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!seen.ContainsKey(c))
                {
                    seen[c] = true;
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
