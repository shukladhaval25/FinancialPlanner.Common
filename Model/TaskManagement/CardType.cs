using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public enum CardType
    {
        Query,
        Task
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public enum TaskStatus
    {        
        Backlog,
        InProgress,
        Blocked,
        Completed,       
        Rejected,
        Close
    }
    public enum OperationType
    {
        Add,
        Modify,
        Delete    
    }
}
