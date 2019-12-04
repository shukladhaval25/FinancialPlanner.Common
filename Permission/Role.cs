using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Permission
{
    public class Role : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCutomRole { get; set; }
        public IList<RolePermission> Permissions { get; set; }
    }
}
