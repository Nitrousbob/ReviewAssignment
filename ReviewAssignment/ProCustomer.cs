using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal class ProCustomer : Customer
    {
        private int DiscountUpperLimit = 5;
        public ProCustomer(string first, string last, string type = "Professional") : base(first, last, type)
        {
            DiscountAmount = 0.25m;
        }

        public override void CalculateDiscountAmount()
        {
            NumOfTransactions++;
            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(.10m);
            }

            Console.WriteLine("Performing a transaction");
            Console.WriteLine("Thank you for being a Pro Customer!");
        }
    }
}
