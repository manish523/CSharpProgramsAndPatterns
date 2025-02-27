namespace PracticeConsoleApp;

public class ArrayManipulations
{
    public int[] reverseArray(int[] input)
    {
        //var rev = array.Reverse();
        //return rev.ToArray();
        int[] revArray = new int[input.Length];
        int j = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            revArray[j] = input[i];
            j++;
        }
        return revArray;
    }

    public int[] reverseBySwapping(int[] input)
    {
        int start = 0, end = input.Length - 1;

        while (start < end)
        {
            int temp = input[start];
            input[start] = input[end];
            input[end] = temp;
            start++;
            end--;

        }
        return input;
    }

    public int[] SortArray(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] > input[j])
                {
                    int larger = input[i];
                    int smaller = input[j];
                    input[i] = smaller;
                    input[j] = larger;
                }
            }
        }
        return input;
    }

    public void ArrayInitializations()
    {
        // Single-dimensional array
        int[] numbers = new int[5]; // Array of size 5
        numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int[] initializedArray = { 1, 2, 3, 4, 5, 6 }; // Initialized array

        // Multi-dimensional array
        int[,] multiDimensional = new int[3, 2]; // 3 rows, 2 columns

        // Jagged array (array of arrays)
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6 };
    }
}
