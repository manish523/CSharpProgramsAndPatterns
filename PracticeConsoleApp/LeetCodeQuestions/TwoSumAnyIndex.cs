using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.LeetCodeQuestions
{
    internal class TwoSumAnyIndex
    {
        public int[] TwoSumOfArrays(int[] nums, int target)
        {
            #region Brute Force
            ////Declarations
            //int arrayLength = nums.Length;

            ////Validations
            //if (nums == null || arrayLength < 2)
            //{
            //    return [];
            //}

            ////Logic
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    for (int j = i + 1; j < arrayLength; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //            return [i, j];
            //    }
            //}
            //return [];
            #endregion

            #region Optimized Solution
            //Declarations
            int arrayLength = nums.Length;
            Dictionary<int, int> resDisctionary = new Dictionary<int, int>();
            //Validations
            if (nums == null || arrayLength < 2)
            {
                return [];
            }
            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;

                if (resDisctionary.TryGetValue(secondNumber, out int index))
                {
                    return [index, i];
                }

                resDisctionary[firstNumber] = i;
            }

            return [];
            #endregion
        }
    }
}
