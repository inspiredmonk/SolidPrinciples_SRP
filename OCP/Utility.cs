using OCP.Implementation;
using OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OCP.Enums.Enums;

namespace OCP
{
    public static class Utility
    {
        public static (IBonusCalculator, IDatabaseProvider) ResolveRoleBonusAbstraction(RoleType role)
        {
            return role switch {
                RoleType.Manager => (new ManagerBonus(), new SQLDatabaseProvider()),
                RoleType.Salespeople => (new SalesPeopleBonus(50000), new SQLDatabaseProvider()),
                _ => (new DefaultBonus(), new SQLDatabaseProvider()),
            };
        }
    }
}
