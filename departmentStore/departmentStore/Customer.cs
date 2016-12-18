using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace departmentStore
{
    class Customer
    {
        private int accountNumber;
        private int balance;
        private int totalItemsCharged;
        private int totalCreditsApplied;
        private int creditLimit;

        public int CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }

        public Customer(int acc, int bal, int totI, int totC, int cre)
        {
            accountNumber = acc;
            balance = bal;
            totalItemsCharged = totI;
            totalCreditsApplied = totC;
            creditLimit = cre;
        }

        public int calculateNewBalance()
        {
            int result = balance + totalItemsCharged - totalCreditsApplied;
            return result;
        }
    }
}
