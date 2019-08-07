using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentService = new PaymentSerivce();
            paymentService.Pay(PaymentType.Cash);
            paymentService.Pay(PaymentType.CreditCard);

            IPaymentService paymentServiceRefactored;
            paymentServiceRefactored = new CashPaymentService();
            paymentServiceRefactored.Pay();
            paymentServiceRefactored = new CreditCardPaymentService();
            paymentServiceRefactored.Pay();
            paymentServiceRefactored = new PayPalPaymentService();
            paymentServiceRefactored.Pay();
        }
    }
}
