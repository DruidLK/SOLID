namespace SOLID.Open_Closed_Principle.Before
{
    public sealed class PaymentService
    {
        //The code is incorrect because it is open for modification.
        //If a new payment method is added, the class has to be changed.
        public void Pay(PaymentMethod paymentMethod)
        {
            // Implementation

            if (paymentMethod is PaymentMethod.Cash) // implementation;
                if (paymentMethod is PaymentMethod.Credit) //implementation;
                    if (paymentMethod is PaymentMethod.Debit) // implementation;
                        System.Console.WriteLine("bah");
            //implementation
        }
    }
}
