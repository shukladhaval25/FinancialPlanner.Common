using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class MinutesOfMeetingDetails
    {
        public int MOMID { get; set; }              
        public string Points { get; set; }
        public string ActionPlan { get; set; }
        public string Responsibility { get; set; }
        public string Status { get; set; }
        public bool IsTaskCreationRequire { get; set; }
        public int? TaskId { get; set; }
    }
}
