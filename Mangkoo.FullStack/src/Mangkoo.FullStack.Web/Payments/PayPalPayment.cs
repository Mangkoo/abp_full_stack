using System;

namespace Mangkoo.FullStack.Web.Payments
{
    public class PayPalPayment : IPayment
    {
        public void Pay (double amount)
        {
            Console.WriteLine($"\n\n\n\n\nFactory: Proceesed {amount} using the PayPal payment type.\n\n\n\n\n");
        }
    }
}
