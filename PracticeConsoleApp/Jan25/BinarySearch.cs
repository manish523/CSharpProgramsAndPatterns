using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    public class BinarySearch
    {
        public static int PerformBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Prevent overflow compared to (left + right) / 2

                if (array[mid] == target)
                {
                    return mid; // Target found
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // Move to the right half
                }
                else
                {
                    right = mid - 1; // Move to the left half
                }
            }

            return -1; // Target not found
        }
    }
}
