using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return input; }
            //return input.ToUpper();
            return (char.ToUpper(input[0]) + input.Substring(1));
        }
    }
}
