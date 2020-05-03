using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection people = new PersonCollection();
            people.Add(new Person { FirstName = "Moe", LastName = "Howard", Age = 63 });
            people.Add(new Person { FirstName = "Curley", LastName = "Howard", Age = 58 });
            people.Add(new Person { FirstName = "Larry", LastName = "Fine", Age = 61 });
            people.Add(new Person { FirstName = "Larry", LastName = "Sanders", Age = 57 });
            people.Add(new Person { FirstName = "Hank", LastName = "Kingsley", Age = 61 });
            people.Add(new Person { FirstName = "Cosmo", LastName = "Kramer", Age = 55 });
            people.Add(new Person { FirstName = "Elaine", LastName = "Benes", Age = 52 });
            people.Add(new Person { FirstName = "Jerry", LastName = "Seinfeld", Age = 55 });
            people.Add(new Person { FirstName = "George", LastName = "Costanza", Age = 53 });
            people.Add(new Person { FirstName = "Art", LastName = "Vandelay", Age = 48 });
            people.Sort();

            Utility.PrintPersonCollection(people);
            Console.ReadKey();

        }
    }
}
