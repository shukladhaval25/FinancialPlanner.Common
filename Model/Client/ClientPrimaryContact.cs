using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ClientPrimaryContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryEmail { get; set; }
        public string PrimaryMobileNo { get; set; }
    }
}
