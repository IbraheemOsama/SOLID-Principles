using System;

namespace OpenClosed
{
    public class CreditCardPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card -20");
        }
    }
}