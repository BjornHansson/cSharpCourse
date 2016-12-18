using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace roundNumbers
{
    class Round
    {
        public void RoundToInteger(double a)
        {
            double temp = Math.Floor(a * 10 + 0.5) / 10;
            Console.WriteLine("Integer: " + Math.Round(temp));
        }

        public void RoundToTenths(double a)
        {
            Console.WriteLine("Nearest tenth: " + Math.Floor(a * 10 + 0.5) / 10);
        }

        public void RoundToHundredths(double a)
        {
            Console.WriteLine("Nearest hundredth: " + Math.Floor(a * 100 + 0.5) / 100);
        }

        public void RoundToThousandths(double a)
        {
            Console.WriteLine("Nearest thousandth: " + Math.Floor(a * 1000 + 0.5) / 1000);
        }
    }
}
