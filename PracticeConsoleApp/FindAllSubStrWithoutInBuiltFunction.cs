using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class FindAllSubStrWithoutInBuiltFunction
    {
       public static void find_Substring(string inputstr, int n)
        {

            // Choose starting point 
            for (int l = 1; l <= n; l++)
            {

                // Choose ending point 
                for (int i = 0; i <= n - l; i++)
                {

                    // Display the substrings 
                    int q = i + l - 1;

                    for (int j = i; j <= q; j++)
                        Console.Write(inputstr[j]);

                    Console.WriteLine();
                }
            }
        }
    }
}
