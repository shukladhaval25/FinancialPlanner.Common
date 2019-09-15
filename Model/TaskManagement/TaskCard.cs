using FinancialPlanner.Common.Model.TaskManagement.MFTransactions;
using FinancialPlanner.Common.Model.TaskManagement.TaskType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskCard : Base
    {
        int id;
        string taskId;
        int projectId;
        string transactionType;

        object taskTransactionType;
       
        CardType type;
        string title;
        int? customerId;
        
        string description;
        Priority priority;
        TaskStatus taskStatus;
        int owner;
        int? assignTo;
        int completedPercentage;

        DateTime actualCompletedDate;
        DateTime dueDate;
        List<string> watchers;
        string projectName;
        string ownerName;
        string assignToName;
        string customerName;

        public int Id { get => id; set => id = value; }
        public string TaskId { get => taskId; set => taskId = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public CardType Type { get => type; set => type = value; }
        public string Title { get => title; set => title = value; }
        public int? CustomerId { get => customerId; set => customerId = value; }
        public string Description { get => description; set => description = value; }
        public Priority Priority { get => priority; set => priority = value; }
        public TaskStatus TaskStatus { get => taskStatus; set => taskStatus = value; }
        public int Owner { get => owner; set => owner = value; }
        public int? AssignTo { get => assignTo; set => assignTo = value; }
        public int CompletedPercentage { get => completedPercentage; set => completedPercentage = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public List<string> Watchers { get => watchers; set => watchers = value; }
        public DateTime ActualCompletedDate { get => actualCompletedDate; set => actualCompletedDate = value; }
        public string TransactionType { get => transactionType; set => transactionType = value; }
        public object TaskTransactionType { get => taskTransactionType; set => taskTransactionType = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string AssignToName { get => assignToName; set => assignToName = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
    }

    public class TaskTransition
    {
        int transitionId;
        string taskId;
        string changeBy;
        TaskStatus priviousStatus;
        TaskStatus currentStatus;
        DateTime? startDate;
        DateTime changeDate;        
    }

    public class TaskHistory
    {
        int id;
        string taskId;
        OperationType operation;
        string previousValue;
        string changeValue;
        string changeBy;
        DateTime changedOn;
        TaskCard taskCard = new TaskCard();
        string jsonStr;
    }
}
