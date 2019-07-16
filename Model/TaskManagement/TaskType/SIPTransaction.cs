using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.TaskType
{
    public class SIPTransaction : ITaskTransactionType
    {
        SIP sip;
        public T GetTransaction<T>()
        {
            T sipObject = default(T);
           // sipObject =  ;
            return sipObject;
        }
    }
}
