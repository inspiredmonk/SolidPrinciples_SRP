

using SRP.Interfaces;

namespace SRP
{
    public class ReportGenerator
    {
        private readonly IDatabaseService _databaseService;
        private readonly IFormatterService _formatterService;
        private readonly IFileSaverService _fileSaverService;
        private readonly IEmailService1 _emailService;

        public ReportGenerator(IDatabaseService databaseService, IFormatterService formatterService, IFileSaverService fileSaverService
            , IEmailService1 emailService) {
            _databaseService = databaseService;
            _formatterService = formatterService;
            _fileSaverService = fileSaverService;
            _emailService = emailService;
        }

        public void GenerateReports ()
        {
            // fetch reports needs to be processed.
            var reportList = _databaseService.fetchReports();
            Console.WriteLine(reportList.Count);


            _formatterService.formatReports(reportList);
            _fileSaverService.saveReports(reportList);
            _emailService.sendEmail();
        }
    }
}
