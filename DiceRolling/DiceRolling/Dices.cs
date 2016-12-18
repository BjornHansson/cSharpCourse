using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRolling
{
    class Dices
    {
        private int dice1;
        private int dice2;
        private int sum;
        private Random rnd = new Random();

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public void rollDices()
        {
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            Sum = dice1 + dice2;
        }
    }
}
