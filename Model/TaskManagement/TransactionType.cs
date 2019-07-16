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
        string projectId;
        string transactionName;

        public int Id { get => id; set => id = value; }
        public string ProjectId { get => projectId; set => projectId = value; }
        public string TransactionName { get => transactionName; set => transactionName = value; }
    }
}
