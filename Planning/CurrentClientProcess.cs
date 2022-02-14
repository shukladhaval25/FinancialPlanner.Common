using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Planning
{
    public class CurrentClientProcess
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ProcessTitle { get; set; }
        public string ProcessStatus { get; set; }
        public int PrimaryStepId { get; set; }
        public int LinkSubStepId { get; set; }
        public int PrimaryStepNo { get; set; }
        public int LinkSubStepNo { get; set; }
        public string RefTaskId { get; set; }
        public int AssignTo { get; set; }
        public string UserName { get; set; }
        public DateTime ExpectedCompletionDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public string TaskStatus { get; set; }
    }
}
