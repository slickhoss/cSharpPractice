using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contact Information\n-------------------------------------");
            Console.Write("First Name:\t");
            string firstName = Console.ReadLine();
            Console.Write("Last Name:\t");
            string lastName = Console.ReadLine();
            Console.Write("Addresss:\t");
            string address = Console.ReadLine();
            Console.Write("City:\t\t");
            string city = Console.ReadLine();
            Console.Write("Province:\t");
            string province = Console.ReadLine();
            Console.Write("Postal Code:\t");
            string postalCode = Console.ReadLine();

            //initialization using property methods
            Contact obj1 = new Contact();
            obj1.FirstName = firstName;
            obj1.LastName = lastName;
            obj1.Address = address;
            obj1.City = city;
            obj1.Province = province;
            obj1.PostalCode = postalCode;

            //initialization using parameterized constructor
            Contact obj2 = new Contact(firstName, lastName, address, city, province, postalCode);

            //initialization using object initializer syntax
            Contact obj3 = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                Province = province,
                PostalCode = postalCode
            };

            Console.WriteLine("\n\nContacts\n-------------------------------------");

            Contact[] contacts = { obj1, obj2, obj3 };
            Utility.PrintContactArray(contacts);
            Console.ReadKey();
        }
    }
}
