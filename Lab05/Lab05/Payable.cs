using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class Payable
    {
        public Payable() { }
        public string Id { get; set; }
        public abstract double CalculatePay();
    }
}
