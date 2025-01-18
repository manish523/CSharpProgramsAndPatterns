using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class FactorialRecursion
    {
        int factNum = 1;
        public int CalculateFactorial(int number)
        {
            factNum = factNum * number;
            number--;
            if (number > 0)
            {
                CalculateFactorial(number);
            }
            return factNum;
        }
    }
}
