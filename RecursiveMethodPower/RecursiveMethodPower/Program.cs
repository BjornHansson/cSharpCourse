using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveMethodPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base: ");
            double baseNr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exponent: ");
            int exponentNr = Convert.ToInt16(Console.ReadLine());

            double result = Pow(baseNr, exponentNr);

            Console.WriteLine("Result: " + result);
        }

        public static double Pow(double baseNr, int exponentNr)
        {
            if (exponentNr == 0)
            {
                return 1;
            }
            else if (exponentNr == 1)
            {
                return baseNr;
            }
            return baseNr * Pow(baseNr, exponentNr - 1);
        }
    }
}
