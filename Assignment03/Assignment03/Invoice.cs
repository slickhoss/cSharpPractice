using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Invoice : List<LineItem>
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DiscountDate { get; set; }
        public string Terms { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GST { get; set; }
        public bool HasPST { get; set; }
        public decimal PST { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
    }
}
