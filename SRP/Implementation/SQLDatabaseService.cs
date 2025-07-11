using SRP.Interfaces;
using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Implementation
{
    public class SQLDatabaseService : IDatabaseService
    {
        public List<ReportMetaData> fetchReports()
        {
            ReportMetaData report1 = new ReportMetaData() { author = "test", lastGenerated = "test", name = "report1" };
            ReportMetaData report2 = new ReportMetaData() { author = "test", lastGenerated = "test", name = "report2" };
            List<ReportMetaData> reportList = new List<ReportMetaData>() { report1, report2 };
            return reportList;
        }
    }
}
