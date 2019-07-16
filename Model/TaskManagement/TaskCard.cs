using FinancialPlanner.Common.Model.TaskManagement.TaskType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskCard
    {
        string id;
        string projectId;
        int transactionType;

        ITaskTransactionType taskTransactionType;

        CardType type;
        string title;
        int? customerId;
        
        string description;
        Priority priority;
        TaskStatus taskStatus;
        string owner;
        string assignTo;
        int completedPercentage;

        DateTime createdDate;
        DateTime updatedDate;
        DateTime actualCompletedDate;
        DateTime dueDate;
        List<string> watchers;

        public string Id { get => id; set => id = value; }
        public string ProjectId { get => projectId; set => projectId = value; }
        public CardType Type { get => type; set => type = value; }
        public string Title { get => title; set => title = value; }
        public int? CustomerId { get => customerId; set => customerId = value; }
        public string Description { get => description; set => description = value; }
        public Priority Priority { get => priority; set => priority = value; }
        public TaskStatus TaskStatus { get => taskStatus; set => taskStatus = value; }
        public string Owner { get => owner; set => owner = value; }
        public string AssignTo { get => assignTo; set => assignTo = value; }
        public int CompletedPercentage { get => completedPercentage; set => completedPercentage = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime UpdatedDate { get => updatedDate; set => updatedDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public List<string> Watchers { get => watchers; set => watchers = value; }
        public DateTime ActualCompletedDate { get => actualCompletedDate; set => actualCompletedDate = value; }
        public int TransactionType { get => transactionType; set => transactionType = value; }
        public ITaskTransactionType TaskTransactionType { get => taskTransactionType; set => taskTransactionType = value; }
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

    public class TaskComment
    {
        int id;
        string taskId;
        string commantedBy;
        List<string> to;
        List<string> cc;
        string comment;
        DateTime commentedOn;

        public int Id { get => id; set => id = value; }
        public string TaskId { get => taskId; set => taskId = value; }
        public string CommantedBy { get => commantedBy; set => commantedBy = value; }
        public List<string> To { get => to; set => to = value; }
        public List<string> Cc { get => cc; set => cc = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime CommentedOn { get => commentedOn; set => commentedOn = value; }
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
        public  TaskHistory()
        {
            ITaskTransactionType sipTransaction = new SIPTransaction();
            taskCard.TaskTransactionType = sipTransaction;
        }
    }
}
