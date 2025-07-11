using SRP.Implementation;
using SRP.Interfaces;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //IValidateInput validateInput = new ValidateInput();
            //IDatabaseOperations databaseOperations = new DatabaseOperations();
            //IEmailService emailService = new EmailService();

            //UserManager userManager = new UserManager(validateInput, databaseOperations, emailService);
            //userManager.RegisterUser("testUser", "testpassword");

            IDatabaseService databaseService = new SQLDatabaseService();
            IFormatterService formatterService = new PDFFormatter();
            IFileSaverService fileSaverService = new BlobStorage();
            IEmailService1 emailService = new EmailService1();
            ReportGenerator reportGenerator = new ReportGenerator(databaseService, formatterService, fileSaverService, emailService);
            reportGenerator.GenerateReports();
        }
    }

}