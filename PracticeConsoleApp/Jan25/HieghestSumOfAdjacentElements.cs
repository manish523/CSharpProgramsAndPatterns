using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    public class HieghestSumOfAdjacentElements
    {
        public static int ReturnMaxSumOfAdjacents(int[] arrInput, int length)
        {
            if (arrInput == null || length <= 0 || arrInput.Length < length)
            {
                throw new ArgumentException("Invalid array or length parameter.");
            }

            int numOfResults = arrInput.Length - length + 1;
            int total = 0;

            for (int i = 0; i < numOfResults; i++)
            {
                int sum = 0;
                for (int j = i; j < i + length; j++)
                {
                    sum += arrInput[j];
                }
                if (total < sum)
                {
                    total = sum;
                }
            }
            return total;
        }
    }
}
