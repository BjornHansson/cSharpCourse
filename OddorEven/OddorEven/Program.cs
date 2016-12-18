using System;
using System.Collections.Generic;
using System.Linq;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, result;
            Console.WriteLine("Enter integer: ");
            input = Convert.ToInt32(Console.ReadLine());
            result = input % 2;
            if (result == 0)
            {
                Console.Write("Even");
            }
            else
            {
                Console.Write("Odd");
            }
            Console.ReadLine();
        }
    }
}
