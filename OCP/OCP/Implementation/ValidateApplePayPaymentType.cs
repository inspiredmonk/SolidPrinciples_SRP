using OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    public class ValidateApplePayPaymentType : IValidatePayments
    {
        private bool isValidate;
        public bool Validate()
        {
            Console.WriteLine("ApplePay Validated Successfully.");
            isValidate = true;
            return isValidate;
        }
    }
}
