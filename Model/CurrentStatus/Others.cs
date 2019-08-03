using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class Others : EPF
    {
        string transactionType;

        public string TransactionType { get => transactionType; set => transactionType = value; }
    }
}
