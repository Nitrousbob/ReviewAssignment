namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer bear = new TrialCustomer("Bear", "Fulmer");   //abstract class then name, then concrete class
            Customer janna = new PremiumCustomer("Janna", "Bean");
            Customer john = new ProCustomer("John", "Baldon");
            DoPurchases(bear);
            DoPurchases(janna);
            DoPurchases(john);
        }

        static void DoPurchases(Customer customer)
        {
            Console.WriteLine("\nStarting Purchases:");
            customer.PrintName();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                //print the resulting discount
                Console.WriteLine($"Customers discount is: {customer.DiscountAmount}");

                //do a purchase for each customer
                customer.CalculateDiscountAmount();

            }
        }
    }
}
