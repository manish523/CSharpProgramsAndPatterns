using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions;

public static class LongestCommonPrefix
{
    public static string Find(string[] strs)
    {
        // Cover edge cases
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];

        // Consider first element as first prefix
        string prefix = strs[0];

        //Loop through each occurence in array
        foreach (string str in strs)
        {
            // Trim the prefix until it matches the start of the string
            while (!str.StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix)) return ""; // No common prefix
            }
        }
        return prefix;
    }
}
