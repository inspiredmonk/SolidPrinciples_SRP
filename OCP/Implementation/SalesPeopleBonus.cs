using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    public class SalesPeopleBonus : IBonusCalculator
    {
        private readonly float _commission = 0;

        public SalesPeopleBonus(float commission)
        {
            _commission = commission;
        }

        public void Calculator(UserMaster user)
        {
            user.IncrementedSalary = user.Salary + ((user.Salary * 15) / 100) + _commission;
        }
    }
}
