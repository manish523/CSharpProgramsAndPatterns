using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions
{
    public class TwoSum
    {
        public int[] TwoSumOfArrays(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int? nextValue = i == nums.Length - 1 ? null : nums[i + 1];
                if (nextValue != null)
                {
                    if (nums[i] + nextValue == target)
                    {
                        return [i, i + 1];
                    }
                }
            }
            return [];
        }
    }
}
