using OCP.Interfaces;
using OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation
{
    public class BonusCalculator
    {
        private readonly IBonusCalculator _bonusCalculator;
        private readonly IDatabaseProvider _databaseProvider;

        public BonusCalculator(IBonusCalculator bonusCalculator, IDatabaseProvider databaseProvider)
        {
            _bonusCalculator = bonusCalculator;
            _databaseProvider = databaseProvider;
        }

        public void CalculateBonus(UserMaster user)
        {
            _bonusCalculator.Calculator(user);
            _databaseProvider.Save(user);
        }
    }
}
