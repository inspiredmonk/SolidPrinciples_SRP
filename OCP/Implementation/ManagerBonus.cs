using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    public class ManagerBonus : IBonusCalculator
    {
        public void Calculator(UserMaster user)
        {
            user.IncrementedSalary = user.Salary + ((user.Salary * 30) / 100);
        }
    }
}
