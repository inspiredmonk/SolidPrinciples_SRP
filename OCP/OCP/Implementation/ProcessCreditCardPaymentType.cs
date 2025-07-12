using OCP.Interfaces;

namespace OCP.Implementation
{
    public class ProcessCreditCardPaymentType: IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("CreditCard Payment gets processed successfully.");
        }
    }
}
