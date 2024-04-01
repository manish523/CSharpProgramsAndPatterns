using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class AnagramCheck
    {
        public bool IsAnagram(string a, string b)
        {
            var dictA = GetDictionary(a);
            var dictB = GetDictionary(b);

            bool result = true;

            if (dictA.Count == dictB.Count)
            {
                foreach (var iterator in dictA)
                {
                    int value;
                    if (dictB.TryGetValue(iterator.Key, out value))
                    {
                        if (value != iterator.Value)
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            if (result)
                Console.WriteLine("Strings are Anagram!");
            else
                Console.WriteLine("Strings are not Anagram!");
            return result;
        }

        public static Dictionary<char, int> GetDictionary(string data)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in data)
            {
                var abc = "def";
                dict.TryGetValue(c, out int count);
                dict[c] = count + 1;
            }

            return dict;
        }
    }
}
