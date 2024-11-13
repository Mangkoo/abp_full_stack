using Serilog.Core;
using System;

namespace Mangkoo.FullStack.Web.Payments
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"\n\n\n\n\nFactory: Proccessed {amount} using the Credit Card payment type.\n\n\n\n\n");
        }
    }
}
