using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions;

public static class FindLongestSubstring
{
    public static void PrintLongestSubstring(string s)
    {
        int n = s.Length;
        int l = 0, r = 0;
        HashSet<char> visited = new HashSet<char>();
        int maxStr = 0;
        int maxL = 0, maxR = 0;
        while (r < n)
        {
            if (!visited.Contains(s[r]))
            {
                visited.Add(s[r]);
                if (r - l + 1 > maxStr)
                {
                    maxStr = r - l + 1;
                    maxL = l;
                    maxR = r;
                }
                r++;
            }
            else
            {
                visited.Remove(s[l]);
                l++;
            }
        }
        for (int i = maxL; i <= maxR; i++)
        {
            Console.Write(s[i]);
        }
        Console.WriteLine();
    }

    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int i = 0, res = 0;

        for (int j = 0; j < s.Length; j++)
        {
            char currentChar = s[j];
            if (seen.ContainsKey(currentChar))
            {
                i = Math.Max(i, seen[currentChar] + 1);
            }
            seen[currentChar] = j;
            res = Math.Max(res, j - i + 1);
        }

        return res;
    }
}

