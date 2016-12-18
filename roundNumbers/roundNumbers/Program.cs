using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace roundNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            String input;
            double nr;
            bool valid;
            Round round = new Round();

            while(start)
            {
                input = Console.ReadLine();
                valid = double.TryParse(input, out nr);
                if (valid)
                {
                    round.RoundToInteger(nr);
                    round.RoundToTenths(nr);
                    round.RoundToHundredths(nr);
                    round.RoundToThousandths(nr);
                }
                else
                {
                    start = false;
                }
            }
            
        }


    }
}
