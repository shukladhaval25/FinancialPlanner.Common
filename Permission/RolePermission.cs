using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Permission
{
    public class RolePermission
    {
        public int RoleId { get; set; }
        public int FormId { get; set; }
        public string FormName { get; set; }
        public bool IsView { get; set; }
        public bool IsAdd { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsCustomRole { get; set; }
    }
}
