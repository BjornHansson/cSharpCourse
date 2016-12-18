using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace departmentStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 200, 100, 200, 500));
            customers.Add(new Customer(2, 200, 100, 100, 100));
            customers.Add(new Customer(3, 200, 100, 100, 200));

            for(int i = 0; i < customers.Count; i++)
            {
                if (customers[i].calculateNewBalance() >= customers[i].CreditLimit)
                {
                    Console.WriteLine("Credit limit exceeded");
                }
            }
        }
    }
}
