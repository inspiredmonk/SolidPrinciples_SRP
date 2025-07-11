using SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Implementation
{
    public class EmailService1 : IEmailService1
    {
        public void sendEmail()
        {
            Console.WriteLine("Email sent successfullly.");
        }
    }
}
