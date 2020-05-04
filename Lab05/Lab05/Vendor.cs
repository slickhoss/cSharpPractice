using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Vendor :Payable
    {
        public Vendor () { }

        public double TotalInvoices { get; set; }

        public override double CalculatePay()
        {
            throw new NotImplementedException();
        }
    }
}
