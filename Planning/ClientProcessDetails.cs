using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Planning
{
    public class ClientProcessDetails
    {
        public int Id { get; set; }
        public int CPID { get; set; }
        public int AssignTo { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime ExpectedCompleteDate { get; set; }
        public DateTime ActualCompleteDate { get; set; }
        public string RefTaskId { get; set; }
    }
}
