using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class GeneralInsuranceRenewalReminder
    {
        public string Applicant { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNo { get; set; }
        public DateTime RenewalDate { get; set; }
        public double PremiumAmount { get; set; }
    }
}
