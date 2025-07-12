using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OCP.Enums.Enums;

namespace OCP.Models
{
    public class UserMaster
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public RoleType Role { get; set; }
        public float IncrementedSalary {  get; set; }
    }
}
