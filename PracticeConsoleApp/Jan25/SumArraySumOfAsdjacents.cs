using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    internal static class SumArraySumOfAsdjacents
    {
        public static int[] SumAdjacents(int[] arr, int length)
        {
            if (arr == null || length <= 0 || arr.Length < length)
            {
                throw new ArgumentException("Invalid array or length parameter.");
            }

            int resultLength = arr.Length - length + 1;
            int[] result = new int[resultLength];

            for (int i = 0; i < resultLength; i++)
            {
                int sum = 0;
                for (int j = i; j < i + length; j++)
                {
                    sum += arr[j];
                }
                result[i] = sum;
            }

            return result;
        }
    }
}
