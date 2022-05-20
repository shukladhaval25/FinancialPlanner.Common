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
        string otherName;

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
        public string OtherName { get => otherName; set => otherName = value; }
        public int? ProcessApprovedBy { get; set; }
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
        int taskId;
        string fieldName;
        string oldValue;
        string newValue;
        string username;
        int updatedBy;
        DateTime updatedOn;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public string FieldName { get => fieldName; set => fieldName = value; }
        public string OldValue { get => oldValue; set => oldValue = value; }
        public string NewValue { get => newValue; set => newValue = value; }
        public string Username { get => username; set => username = value; }
        public int UpdatedBy { get => updatedBy; set => updatedBy = value; }
        public DateTime UpdatedOn { get => updatedOn; set => updatedOn = value; }
    }

    public class TaskProcessByPassApproval
    {
        public string TaskId { get; set; }
        public int ProcessApprovedBy { get; set; }
        public DateTime ProcessApprovedOn { get; set; }
    }
}
