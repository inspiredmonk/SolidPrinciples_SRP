using OCP.Implementation;
using OCP.Interfaces;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            string paymentType = "ApplePay";

            if (paymentType == "CreditCard")
            {
                IValidatePayments _validatePayments = new ValidateCreditCardPaymentType();
                IPaymentProcessor _processPayments = new ProcessCreditCardPaymentType();
                PaymentProcessor paymentProcessor = new PaymentProcessor(_validatePayments, _processPayments);
                paymentProcessor.ProcessPayment();
            }
            if (paymentType == "ApplePay")
            {
                IValidatePayments _validatePayments = new ValidateApplePayPaymentType();
                IPaymentProcessor _processPayments = new ProcessApplePayPaymentType();
                PaymentProcessor paymentProcessor = new PaymentProcessor(_validatePayments, _processPayments);
                paymentProcessor.ProcessPayment();
            }
        }
    }
}