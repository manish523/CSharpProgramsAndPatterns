using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class SwapNumber
    {
        public SwapNumber()
        {

            int firstNumber, secondNumber, temp;

            Console.WriteLine("Enter First Number : ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            secondNumber = int.Parse(Console.ReadLine());

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"After swapping first number is:{firstNumber} and second number is:{secondNumber}");

        }
    }
}
