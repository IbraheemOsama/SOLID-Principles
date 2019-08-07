using System;

namespace OpenClosed
{
    public class PayPalPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine("PayPal -30");
        }
    }
}