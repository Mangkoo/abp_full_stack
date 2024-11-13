using System;

namespace Mangkoo.FullStack.Web.Payments
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.Paypal:
                    return new PayPalPayment();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
