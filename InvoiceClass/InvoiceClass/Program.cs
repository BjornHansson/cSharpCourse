using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice();
            Console.WriteLine(inv.Price);
            inv.Price = -2;
            Console.WriteLine(inv.Price);
            inv.Price = 3;
            Console.WriteLine(inv.Price);

            Invoice inv2 = new Invoice("Test", "testar", 5, 20);
            Console.WriteLine(inv2.GetInvoiceAmount());

            Console.ReadLine();
        }
    }
}
