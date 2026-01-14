using System;
using System.Collections.Generic;
using System.Text;

// jesse was here

namespace ReviewAssignment
{
    internal class TrialCustomer : Customer
    {
        private int DiscountUpperLimit = 3; //max number of transactions for trial customer
        public TrialCustomer(string first, string last, string type = "Trial") : base(first, last, type)  //: extends the properties to the customer constructor
        {
            DiscountAmount = 0.1m;
        }
        public override void CalculateDiscountAmount()
        {
            NumOfTransactions++;
            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0);
            }

            Console.WriteLine("Performing a transaction");
        }
    }
}
