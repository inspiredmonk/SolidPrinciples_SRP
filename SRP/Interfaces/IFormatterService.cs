using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Interfaces
{
    public interface IFormatterService
    {
        public void formatReports(List<ReportMetaData> reports);
    }
}
