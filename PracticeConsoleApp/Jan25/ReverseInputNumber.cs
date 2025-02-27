using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Jan25
{
    internal class ReverseInputNumber
    {
        public static int ReverserInputNumber(int x)
        {
            int num = x;
            long reverse = 0; // long can hold min or max value of int
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;

                //check for int overflow
                if (reverse > int.MaxValue || reverse < int.MinValue)
                {
                    reverse = 0;
                    break;
                }
                num /= 10;
            }

            return (int)reverse;
        }

        public static int Reverse(int x)
        {
            int rev = 0;
            int digits = 0;

            while (x != 0)
            {
                x = Math.DivRem(x, 10, out int rem);
                if (digits++ == 9)
                {
                    int max = int.MaxValue / 10;
                    if (rev > max || (rev == max && rem > 7)) return 0;
                    int min = int.MinValue / 10;
                    if (rev < min || (rev == min && rem < -8)) return 0;
                }

                rev = rev * 10 + rem;
            }

            return rev;
        }
    }
}
