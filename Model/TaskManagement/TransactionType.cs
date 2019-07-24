using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class TransactionType : Base
    {
        int id;
        int projectId;
        string transactionName;
        string description;

        public int Id { get => id; set => id = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public string TransactionName { get => transactionName; set => transactionName = value; }
        public string Description { get => description; set => description = value; }
    }
}
