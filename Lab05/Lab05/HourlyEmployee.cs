using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee() { }

        public int Hours { get; set; }
        public double Wage { get; set; }

        public override double CalculatePay()
        {
            return Wage * Convert.ToDouble(Hours);
        }
    }
}
