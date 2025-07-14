using OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    internal class ProcessApplePayPaymentType : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Apple Pay Payment gets processed successfully.");
        }
    }
}
