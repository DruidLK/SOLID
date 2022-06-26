using SOLID.Open_Closed_Principle.After.Contracts;

namespace SOLID.Open_Closed_Principle.After.TypeOfPayments
{
    public sealed class CreditCard : IPaymentMethod
    {
        public void Pay() =>
            System.Console.WriteLine(nameof(CreditCard));
    }
}
