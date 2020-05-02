using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null; //declare streamReader
            string path = @"..\..\..\data.txt"; //relative path for the data text file
            string lineData;

            if (!File.Exists(path)) //error checking
            {
                Console.WriteLine("File not found");
            }
            else
            {
                try
                {
                    int totalAge = 0;
                    int count = 0;
                    double average = 0;
                    Console.WriteLine("First Name \tLast Name \tAge\n-----------------------------------");
                    streamReader = new StreamReader(path); //defining
                    while ((lineData = streamReader.ReadLine()) != null)
                    {
                        string[] data = lineData.Split(',');
                        Console.WriteLine($"{data[0],-15} {data[1], -16} {data[2]}");
                        totalAge += Int16.Parse(data[2]);
                        count++;
                    }
                    average = Convert.ToDouble(totalAge) / Convert.ToDouble(count);
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"\t\tTotal:{totalAge, 13}\n\t\tCount:{count, 13}\n\t\tAverage:{average, 11:N1}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            }
            Console.ReadKey();
        }
    }
}
