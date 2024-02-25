using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class PatternOne
    {
        public static void PrintPatternStar(int n)
        {
            Console.WriteLine("Enter number of rows for pattern:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintPatternNumber(int n)
        {
            Console.WriteLine("Enter number of rows for pattern:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void ArrowStar(int n)
        {
            for (int row = 1; row < n * 2; row++)
            {
                int totalColsInRow = row > n ? 2 * n - row : row;
                for (int j = 1; j <= totalColsInRow; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
