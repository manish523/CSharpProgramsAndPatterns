using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class BubbleSort
    {
        public BubbleSort()
        {
            int[] UnOrderedNumbers = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
            Console.WriteLine($"Unsorted numbers are: {string.Join(", ", UnOrderedNumbers)}");
            int temp = 0;
            for (int i = 0; i < UnOrderedNumbers.Length; i++)
            {
                for (int j = i + 1; j < UnOrderedNumbers.Length; j++)
                {
                    if (UnOrderedNumbers[i] > UnOrderedNumbers[j])
                    {
                        temp = UnOrderedNumbers[j];
                        UnOrderedNumbers[j] = UnOrderedNumbers[i];
                        UnOrderedNumbers[i] = temp;
                    }
                }
            }
            Console.WriteLine($"Sorted numbers are: {string.Join(", ", UnOrderedNumbers)}");
        }
    }
}
