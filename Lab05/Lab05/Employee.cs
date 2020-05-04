using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Employee : Payable
    {
        public Employee () { }

        public override double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
