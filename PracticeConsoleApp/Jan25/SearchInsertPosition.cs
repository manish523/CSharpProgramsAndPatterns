using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int pos = Array.FindIndex(nums, x => x == target);
            if (pos != -1) return pos;

            for (int i = 0; i < nums.Length; i++)
            {
                //if (i == nums.Length - 1) return i + 1;
                if (nums[i] > target)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
