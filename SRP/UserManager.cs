using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public interface IValidateInput
    {
        public bool validateUserInput(string username, string password);
    }

    public interface IDatabaseOperations
    {
        public bool SaveInput();
    }

    public interface IEmailService
    {
        public void sendEmail();
    }

    public class ValidateInput : IValidateInput
    {
        public bool validateUserInput(string username, string password)
        {
            return true;
            //validate code here
        }
    }

    public class DatabaseOperations : IDatabaseOperations
    {
        public bool SaveInput()
        {
            return true;
            //validate code here
        }
    }

    public class EmailService : IEmailService
    {
        public void sendEmail()
        {

        }
    }

    /// <summary>
    /// Scenario 1: Where we need to implement Single Responsibility Principle in UserManager Class
    /// </summary>
    public class UserManager
    {
        private readonly IValidateInput _validateInput;
        private readonly IDatabaseOperations _databaseOperations;
        private readonly IEmailService _emailService;

        public UserManager(IValidateInput validateInput, IDatabaseOperations databaseOperations, IEmailService emailService)
        {
            _validateInput = validateInput;
            _databaseOperations = databaseOperations;
            _emailService = emailService;
        }

        public void RegisterUser(string username, string password)
        {
            _validateInput.validateUserInput(username, password); // Validate input
            _databaseOperations.SaveInput();  // Save to database
            _emailService.sendEmail(); // Send welcome email
        }
    }
}
