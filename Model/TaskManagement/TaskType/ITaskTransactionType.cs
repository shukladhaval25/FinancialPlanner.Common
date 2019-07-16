using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.TaskType
{
    public interface ITaskTransactionType
    {
        T GetTransaction<T>();
    }
}
