using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Permission
{
    public class Forms
    {
        int id;
        string formName;
        string groupName;

        public int Id { get => id; set => id = value; }
        public string FormName { get => formName; set => formName = value; }
        public string GroupName { get => groupName;set => groupName = value; }
    }
}
