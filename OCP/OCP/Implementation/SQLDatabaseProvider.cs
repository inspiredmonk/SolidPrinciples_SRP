using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    public class SQLDatabaseProvider: IDatabaseProvider
    {
        public void Save (UserMaster user)
        {
            Console.WriteLine("User suuccessfully saved - {0} with incremented salary = {1}", user.Name, user.IncrementedSalary);
        }
    }
}
