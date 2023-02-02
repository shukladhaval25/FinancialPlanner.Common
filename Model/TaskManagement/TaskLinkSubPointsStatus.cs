using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskLinkSubPointsStatus
    {
        public int Id { get; set; }
        public int CId { get; set; }
        public string Point { get; set; }
        public string Status { get; set; }
    }
}
