using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TaskComment
    {
        int id;
        int taskId;
        int commantedBy;
        string commentedByName;
        string comment;
        DateTime commentedOn;
        bool isEditable;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int CommantedBy { get => commantedBy; set => commantedBy = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime CommentedOn { get => commentedOn; set => commentedOn = value; }
        public bool IsEditable { get => isEditable; set => isEditable = value; }
        public string CommentedByName { get => commentedByName; set => commentedByName = value; }
    }
}
