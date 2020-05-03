using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class PersonCollection : List<Person>
    {
        public PersonCollection() { } //default CTR
        public PersonCollection(int capacity) : base(capacity) { } //CTR to enable pre-
        
        //calculated properties
        public int TotalAge()
        {
            int TotalAge = 0;
            foreach (Person p in this) //syntax to iterate through self collection
            {
                TotalAge += p.Age;
            }
            return TotalAge;
        }

        public double AverageAge()
        {
            int count = 0;
            foreach (Person p in this)
            {
                count++;
            }
            return Convert.ToDouble(TotalAge()) / Convert.ToDouble(count);
        }
    }
}
