using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }




        public int CompareTo(Person other)
        {
            if (other == null)
            {
                return 1;
            }

           
            if (this.LastName.CompareTo(other.LastName) != 0)
                return this.LastName.CompareTo(other.LastName); //sorts by lastname ascending
            else return this.FirstName.CompareTo(other.FirstName); //if lastname is equal sorts by firstName
        }
    }
}
