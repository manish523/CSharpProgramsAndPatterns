using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25;

public class LongestPalindromicSubString
{
    public string Find(string s)
    {
        string returnStr = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            string subString = string.Empty;
            for (int j = i; j < s.Length; j++)
            {
                subString += s[j];
                if (CheckPalindrome(subString))
                {
                    returnStr = returnStr.Length < subString.Length ? subString : returnStr;
                };
            }
        }
        return returnStr;
    }

    private bool CheckPalindrome(string str)
    {
        int start = 0, end = str.Length - 1;

        for (int i = start; i < end; i++)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
