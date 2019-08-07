using System;

namespace OpenClosed
{
    public class PaymentSerivce
    {
        public void Pay(PaymentType paymentType)
        {
            if (paymentType == PaymentType.Cash)
            {
                Console.WriteLine("Cash -10");
            }
            else if (paymentType == PaymentType.CreditCard)
            {
                Console.WriteLine("Credit Card -20");
            }
        }
    }
}