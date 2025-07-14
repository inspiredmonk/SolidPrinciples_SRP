using OCP.Interfaces;

namespace OCP.Implementation
{
    public class PaymentProcessor
    {
        private readonly IValidatePayments _validatePayments;
        private readonly IPaymentProcessor _processPayments;
        public PaymentProcessor(IValidatePayments validatePayments, IPaymentProcessor processPayments)
        {
            _validatePayments = validatePayments;
            _processPayments = processPayments;
        }

        public void ProcessPayment()
        {
            bool isValidate = _validatePayments.Validate();
            if (isValidate)
            {
                _processPayments.ProcessPayment();
            }
        }
    }
}
