using System;

namespace OpenClosed
{
    public class CashPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine("Cash -10");
        }
    }
}