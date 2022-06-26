using SOLID.Open_Closed_Principle.After.Contracts;

namespace SOLID.Open_Closed_Principle.After
{
    public sealed class PaymentService
    {
        //The Open Closed Principle says the code must be open for extension and closed for modification.
        //The code is correct because if a new payment method is added the class is not modified.

        //long term collaboration using field

        private readonly IPaymentMethod paymentMethod1;
        public PaymentService(IPaymentMethod paymentMethod1) =>
            this.paymentMethod1 = paymentMethod1;

        //short term collaboration with the interface can be changed during the lifetime
        // of the object
        public void Pay(IPaymentMethod paymentMethod) =>
            paymentMethod.Pay();
    }
}
