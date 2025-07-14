using OCP.Interfaces;


namespace OCP.Implementation
{
    public class ValidateCreditCardPaymentType: IValidatePayments
    {
        private bool isValidate;
        public bool Validate()
        {
            Console.WriteLine("Credit Card Validated Successfully.");
            isValidate = true;
            return isValidate;
        }
    }
}
