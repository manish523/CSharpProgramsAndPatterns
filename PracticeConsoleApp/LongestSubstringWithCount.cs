using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class LongestSubstringWithCount
    {
        public static void PrintLongestSubstringWithCount()
        {
            string str = "aaaabbaaccde";
            Console.Write(maxRepeating(str));
            //string str = "abbcccd";
            //string lastChar = "";
            //string longestStr = "";
            //Dictionary<char, int> dictString = new Dictionary<char, int>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    dictString.TryGetValue(str[i], out int count);
            //    dictString[str[i]] = count + 1;
            //}
            //var maxValue = dictString.Values.Max();

            //var result = dictString.Where(x => x.Value == maxValue).FirstOrDefault();

            //Console.WriteLine(result.Key.ToString() + ' ' + result.Value.ToString());
        }

        static char maxRepeating(string str)
        {
            int len = str.Length;
            int count = 0;
            char res = str[0];

            // Find the maximum repeating 
            // character starting from str[i]
            for (int i = 0; i < len; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] != str[j])
                        break;
                    cur_count++;
                }

                // Update result if required
                if (cur_count > count)
                {
                    count = cur_count;
                    res = str[i];
                }
            }
            return res;
        }
    }
}
