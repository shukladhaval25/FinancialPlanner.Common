using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class UserPerformanceOnTask
    {
        int userId;
        string period;
        int completedTaskCount;
        int overDueTaskCount;

        public int UserId { get => userId; set => userId = value; }
        public string Period { get => period; set => period = value; }
        public int CompletedTaskCount { get => completedTaskCount; set => completedTaskCount = value; }
        public int OverDueTaskCount { get => overDueTaskCount; set => overDueTaskCount = value; }
    }
}
