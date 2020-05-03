using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Contact
    {
        public Contact () { }
        public Contact (string firstName, string lastName, string address, string city, string province, string postalCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.LastName, this.FirstName);
        }

    }
}
