using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class ReverseString
    {
        public ReverseString()
        {
            string sourceString = string.Empty;
            string reverseString = string.Empty;
            Console.WriteLine("Please enter string that you want to reverse: ");
            sourceString = Console.ReadLine();

            for (int i = sourceString.Length - 1; i >= 0; i--)
            {
                reverseString += sourceString[i];
            }
            Console.WriteLine($"Source String: {sourceString}\nReverse String: {reverseString}");
        }
    }
}
