using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CustomNotifier
{
    public class ClientDOB
    {
        public string ClientName { get; set; }
        public DateTime DOB { get; set; }
        public string SpouseName { get; set; }
        public DateTime SpouseDOB { get; set; }
    }
}
