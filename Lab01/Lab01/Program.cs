using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();
            if (password == "ma5_t3r")
            {
                Console.WriteLine("Hello " + name + ", and welcome.");
            }
            else
            {
                Console.Write("Password not recognized");
            }
            Console.ReadKey();
        }
    }
}
