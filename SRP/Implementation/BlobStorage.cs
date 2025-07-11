using SRP.Interfaces;
using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Implementation
{
    public class BlobStorage : IFileSaverService
    {
        public void saveReports(List<ReportMetaData> reports)
        {
            foreach (var report in reports)
            {
                Console.WriteLine("report = {0} saved to blob storage", report.name);
            }
        }
    }
}
