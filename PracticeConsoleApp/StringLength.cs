using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class StringLength
    {
        public StringLength()
        {

            Console.WriteLine("Enter you string: ");
            string str = Console.ReadLine();

            int count = 0;

            foreach (char c in str)
            {
                count++;
            }

            Console.WriteLine($"String length is: {str?.Length.ToString()}");
            Console.WriteLine($"String length count: {count.ToString()}");

        }
    }
}
