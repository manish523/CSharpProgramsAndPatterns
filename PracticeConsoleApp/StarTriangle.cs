using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{

    internal class StarTriangle : StarTriangle2
    {
        public void PrintSTar()
        {
            Console.WriteLine("Triangle program\n\n");
            int j = 4;
            for (int abc = 1; abc < 6; abc++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > j; k--)
                {
                    Console.Write("* ");
                }
                j--;
                Console.WriteLine();
            }
        }
    }

    public class StarTriangle2
    {
        public void PrintSTar(string input)
        {
            Console.WriteLine(input);
        }
    }
}
