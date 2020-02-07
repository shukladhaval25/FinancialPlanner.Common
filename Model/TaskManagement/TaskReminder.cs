using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskReminder
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime ReminderDate { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Description { get; set; }
        public bool ReminderDisplayed { get; set; }
    }
}
