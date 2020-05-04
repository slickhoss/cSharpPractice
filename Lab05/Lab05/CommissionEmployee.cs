using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class CommissionEmployee :Employee
    {
        public CommissionEmployee() { }

        public double CommissionRate { get; set; }
        public double Sales { get; set; }
        
        public override double CalculatePay()
        {
            return CommissionRate * Sales;
        }
    }
}
