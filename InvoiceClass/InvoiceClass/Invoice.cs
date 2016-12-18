using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceTest
{
    class Invoice
    {
        private String partNumber;
        public String PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        private String partDesciption;
        public String PartDesciption
        {
            get { return partDesciption; }
            set { partDesciption = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > -1)
                {
                    quantity = value;
                }
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > -1)
                {
                    price = value;
                }
            }
        }

        public Invoice()
        {
            partNumber = "empty";
            partDesciption = "empty";
            quantity = 0;
            price = 0;
        }

        public Invoice(String num, String des, int qua, int pri)
        {
            partNumber = num;
            partDesciption = des;
            quantity = qua;
            price = pri;
        }

        public decimal GetInvoiceAmount()
        {
            decimal result = (decimal)quantity * price;
            return result;
        }
    }
}
