using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.RolesSecurity
{
    public class Roles
    {
        int _id;
        string _name;
        string _description;
        IList<RolesSecurity> _rolesSecuritis;
    }
}
