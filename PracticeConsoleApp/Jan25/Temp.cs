using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25;

internal class Temp
{
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    public void CountOccurence(string str)
    {   
        int count = 0;
        char selectedChar = str[0];
        for (int i = 0; i <= str.Length - 1; i++)
        {
            char currentChar = str[i];
            int innerCount = 0;
            for (int j = 0; j <= str.Length - 1; j++)
            {
                if (currentChar == str[j])
                {
                    innerCount++;
                }
            }
            if (count < innerCount)
            {
                selectedChar = currentChar;
                count = innerCount;
            }
        }
        Console.WriteLine($"Character with highest occurence in string \"{str}\" is {selectedChar} occuring {count} times");
    }
}
