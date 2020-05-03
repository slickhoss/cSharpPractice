using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTotal = 0;
            int squareTotal = 0;
            int cubeTotal = 0;

            Console.WriteLine("\tnumber\tsquare\t\tcube\n------------------------------------");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    numberTotal += i;
                    squareTotal += i * i;
                    cubeTotal += i * i * i;
                    Console.WriteLine($"{i,14} {i * i,7} {i * i * i,13:N0}");
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{numberTotal,14} {squareTotal, 7:N0} {cubeTotal, 13:N0}");
            Console.ReadKey();
        }
    }
}
