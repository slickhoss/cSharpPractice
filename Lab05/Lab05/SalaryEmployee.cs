using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class SalaryEmployee : Employee
    {
        public SalaryEmployee () { }

        public double Salary { get; set; }
        public override double CalculatePay()
        {
            return Salary / 26;
        }
    }
}
