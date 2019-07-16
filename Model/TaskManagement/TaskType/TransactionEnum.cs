using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.TaskType
{   
    public enum TransactionOption
    {
        GR,
        WDR,
        DD
    }

    public enum TransactionModeOfExecution
    {
        BSE,
        AMC,
        AppOrPhysical
    }
}
