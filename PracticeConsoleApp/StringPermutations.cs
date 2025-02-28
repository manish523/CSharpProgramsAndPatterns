﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class StringPermutations
    {
        public static void Permute(string str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i < r; i++)
                {
                    str = swap(str, l, i);
                    Permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        private static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
