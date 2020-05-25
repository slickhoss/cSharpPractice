using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            string path = args[0];
            string lineData;
            if(File.Exists(path))
            {
                List<Invoice> invoices = new List<Invoice>();
                streamReader = new StreamReader(path);
                while ((lineData = streamReader.ReadLine()) != null)
                {
                    string[] invoiceDetails = lineData.Split('|');
                    string[] headerElements = invoiceDetails[0].Split(':');

                    Invoice inv = new Invoice() { InvoiceNumber = headerElements[0], InvoiceDate = Convert.ToDateTime(headerElements[1]), Discount = (decimal.Parse(headerElements[2][0].ToString())), DiscountDate = Convert.ToDateTime(headerElements[1]).AddDays(Int16.Parse(headerElements[2].Substring(1))) };
                    
                    List<string> lineDetails = new List<string>();
                    for (int i = 1; i < invoiceDetails.Length; i++)
                    {
                        lineDetails.Add(invoiceDetails[i]);   
                    }

                    foreach (string details in lineDetails)
                    {
                        string[] detail = details.Split(':');
                        LineItem lineItem = new LineItem() { Quantity = Convert.ToInt16(detail[0]), Sku = detail[1], Description = detail[2], Price = Convert.ToDecimal(detail[3]), PST = Convert.ToChar(detail[4]), EXT = Convert.ToInt16(detail[0]) * Convert.ToDecimal(detail[3]) };
                        inv.Add(lineItem);
                    }

                    Console.WriteLine("Invoice Listing\n-----------------------------------------------------------\n");
                    Console.WriteLine($"Invoice Number: {inv.InvoiceNumber, 10}"  );
                    Console.WriteLine($"Invoice Date: {inv.InvoiceDate.ToString("MMM dd, yyyy"), 17}");
                    Console.WriteLine($"Discount Date: {inv.DiscountDate.ToString("MMM dd, yyyy"),16}");
                    Console.WriteLine($"Terms: {inv.Discount, 13}% {headerElements[2].Substring(1)} days ADI");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Qty  SKU\tDescription\t\tPrice\tPST\tExt");
                    Console.WriteLine("-----------------------------------------------------------");
                    foreach (LineItem item in inv)
                    {

                        inv.SubTotal += item.EXT;
                        inv.GST += item.EXT * (decimal)0.05;
                        inv.PST += 0;                       
                        if (item.PST == 'Y')
                        {
                            inv.HasPST = true;
                            inv.PST += item.EXT * (decimal)0.07;
                        }
 
                        inv.Total = inv.GST + inv.PST + inv.SubTotal;


                        Console.WriteLine($"{item.Quantity, 3}  {item.Sku, -10} {item.Description, -20} {item.Price, 8} {item.PST, 4} {item.EXT, 8}");
                    }
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"{"Subtotal:",24} {inv.SubTotal, 34}");
                    Console.WriteLine($"{"GST:",24} {inv.GST,34:N2}");
                    if (inv.HasPST == true)
                        Console.WriteLine($"{"PST:",24} {inv.PST,34:N2}");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"{"Total:",24} {inv.Total,34:N2}\n");
                    Console.WriteLine($"{"Discount:",24} {inv.Total * (inv.Discount / 100),34:N2}\n");


                }
            }
            Console.ReadLine();
        }
    }
}
