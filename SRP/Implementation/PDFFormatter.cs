using SRP.Interfaces;
using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Implementation
{
    public class PDFFormatter : IFormatterService
    {
        public void formatReports(List<ReportMetaData> reports)
        {
            foreach (var report in reports)
            {
                Console.WriteLine("PDF generated for report = {0}", report.name);
            }
        }
    }
}
