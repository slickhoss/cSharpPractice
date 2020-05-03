using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    static class Utility
    {
        public static void PrintPersonCollection(PersonCollection people)
        { 
            int totalPersons = 0;
            int totalAge = 0;
            Console.WriteLine("Last Name\tFirst Name\tAge\n-----------------------------------");
            foreach (Person p in people)
            {
                totalPersons++;
                totalAge += p.Age;
                Console.WriteLine($"{p.LastName,-15} {p.FirstName,-16} {p.Age}");
            }
            Console.WriteLine($"-----------------------------------\nTotal Persons:\t{totalPersons}\nTotal Age:\t{totalAge}\nAverage Age:\t{Convert.ToDouble(totalAge) / Convert.ToDouble(totalPersons):N2}");
        }
    }
}
