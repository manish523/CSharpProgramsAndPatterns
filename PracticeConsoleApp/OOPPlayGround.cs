using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class OOPPlayGround
    {
        private readonly string _abc = "q";
        public OOPPlayGround(string abd)
        {
            this._abc = abd;
        }
        private void ChkEquiality(string str, string str2)
        {
            var abd = this._abc;
            if (str == str2)
            {
                var v = "hello";
            }
            if (str.Equals(str2))
            {
                var v = "hello";
            }
        }
    }
}
