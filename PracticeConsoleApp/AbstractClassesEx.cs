using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount();
    }

    public class PlatinumCustomer : Customer
    {

        public override decimal CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }

}
