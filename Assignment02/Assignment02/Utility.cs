using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    static class Utility
    {
        public static void PrintContactArray(Contact[] contacts)
        {
            foreach (Contact c in contacts)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName}\n{c.Address}\n{c.City} {c.Province} {c.PostalCode}\n\n\n");
            }
        }
    }
}
