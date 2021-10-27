using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class PersonalAccidentInsurance
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string Name { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string SumAssured { get; set; }
        public double Premium { get; set; }
    }
}
