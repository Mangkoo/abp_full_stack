namespace Mangkoo.FullStack.Web.Payments
{
    // Factory: Interface that allows interaction with related conctrete classes.
    public interface IPayment
    {
        void Pay(double amount);
    }
}
