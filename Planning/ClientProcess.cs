using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Planning
{
    public class ClientProcess
    {
        public int Id;
        public int ClientId;
        public int PlannerId;
        public int PrimaryStepId;
        public int LinkStepId;
        public String Status;
        public bool IsProcespectClient;
    }
}
