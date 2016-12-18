using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 4; k++)
                        Console.Write('*');
                    Console.WriteLine();
                } // end inner for
                Console.WriteLine();
            } // end outer for
        }
    }
}
