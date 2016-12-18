using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalSales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sales = new int[5, 5]; // rectangular array
            int salesPersonNr = 0;
            int productNr;
            int amountNr;

            while (salesPersonNr != -1)
            {
                Console.Write("Enter the sales person number (-1 to end): ");
                salesPersonNr = Convert.ToInt16(Console.ReadLine());

                if (salesPersonNr != -1)
                {
                    Console.Write("Enter product number: ");
                    productNr = Convert.ToInt16(Console.ReadLine());

                    if (salesPersonNr > 3 || productNr > 5)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    else
                    {
                        Console.Write("Enter sales amount: ");
                        amountNr = Convert.ToInt16(Console.ReadLine());
                        sales[salesPersonNr - 1, productNr - 1] += amountNr;
                    }
                }
            }
            
            Console.WriteLine("Product\tSalesperson 1\tSalesperson 2\tSalesperson3\tTotal");

            int totalSales;
            int output;
            int i, j;

            for (i = 0; i < 5; i++) 
            {
                totalSales = 0;
                Console.Write(i+1);
                for (j = 0; j < 3; j++) 
                {
                    output = sales[j, i];
                    Console.Write("\t" + output + "\t");
                    
                    totalSales += sales[j, i];
                }
                Console.WriteLine("\t" + totalSales);
            }

            Console.Write("Total\t");
            for (i = 0; i < 3; i++)
            {
                totalSales = 0;
                for (j = 0; j < 5; j++)
                {
                    totalSales += sales[i, j];
                }
                Console.Write(totalSales + "\t\t");
            }
            Console.WriteLine("");
        }
    }
}
