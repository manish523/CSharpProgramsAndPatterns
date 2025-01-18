using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class AsyncLambda
    {
        static AsyncLambda()
        {
            int j = 0;
            while (j < 5)
            {
                myTask(j);
                Console.WriteLine("Hello");
                j += 1;
            }
        }

        static async void myTask(int k)
        {
            int val;
            val = 0;
            await Task.Run(() =>
            {
                for (int i = k; i < 50000; i++)
                {
                    val += i;
                }
            });
            Console.WriteLine("Value = {0}:", val);    
        }
    }
}
