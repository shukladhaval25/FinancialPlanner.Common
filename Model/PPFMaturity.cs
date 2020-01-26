using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class PPFMaturity
    {
        public string InvesterName { get; set; }
        public string ClientName { get; set; }
        public string AccountNo { get; set; }
        public string BankName { get; set; }
        public DateTime MaturityDate { get; set; }
        public bool IsAccountExtended { get; set; }

    }
}
