using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariousExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            b = 1;
            c = 0;
            try
            {
                a = b/c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            object o2 = null;
            try
            {
                int i2 = (int)o2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
