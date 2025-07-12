using OCP.Implementation;
using OCP.Interfaces;
using OCP.Models;
using static OCP.Enums.Enums;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //string paymentType = "ApplePay";

            //if (paymentType == "CreditCard")
            //{
            //    IValidatePayments _validatePayments = new ValidateCreditCardPaymentType();
            //    IPaymentProcessor _processPayments = new ProcessCreditCardPaymentType();
            //    PaymentProcessor paymentProcessor = new PaymentProcessor(_validatePayments, _processPayments);
            //    paymentProcessor.ProcessPayment();
            //}
            //if (paymentType == "ApplePay")
            //{
            //    IValidatePayments _validatePayments = new ValidateApplePayPaymentType();
            //    IPaymentProcessor _processPayments = new ProcessApplePayPaymentType();
            //    PaymentProcessor paymentProcessor = new PaymentProcessor(_validatePayments, _processPayments);
            //    paymentProcessor.ProcessPayment();
            //}

            
            UserMaster user1 = new UserMaster() { Name = "Himanshu", Salary = 100000000, Role = RoleType.Manager };
            UserMaster user2 = new UserMaster() { Name = "Bhanu", Salary = 50000000, Role = RoleType.Developer };
            UserMaster user3 = new UserMaster() { Name = "Jitender", Salary = 30000000, Role = RoleType.Salespeople };
            UserMaster user4 = new UserMaster() { Name = "Lakshmi", Salary = 130000000, Role = RoleType.Finance };
            UserMaster user5 = new UserMaster() { Name = "Goyam", Salary = 120000000, Role = RoleType.HR };

            List<UserMaster> userMasterList = new List<UserMaster>() { user1, user2, user3, user4, user5 };

            
            foreach (UserMaster userMaster in userMasterList)
            {
                var (_bonusCalculator, _databaseProvider) = Utility.ResolveRoleBonusAbstraction(userMaster.Role);

                BonusCalculator bonus = new BonusCalculator(_bonusCalculator, _databaseProvider);
                bonus.CalculateBonus(userMaster);
            }
        }
    }
}