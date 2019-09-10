using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskNotification
    {
        int taskId;
        int notifyTo;

        public int TaskId { get => taskId; set => taskId = value; }
        public int NotifyTo { get => notifyTo; set => notifyTo = value; }
    }
}
