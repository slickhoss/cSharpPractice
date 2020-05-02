using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Member
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public double AgeInDecades ()
        {
            return Convert.ToDouble(Age) / 10;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", FirstName, LastName);
        }
    }
}
