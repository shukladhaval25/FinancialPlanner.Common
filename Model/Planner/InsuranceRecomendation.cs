using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class InsuranceRecomendation
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int CId { get; set; }
        public int SpouseId { get; set; }
        public string Name { get; set; }
        public string SumAssured { get; set; }
        public string Description { get; set; }
    }

    public class InsuranceRecomendationDetail
    {
        public int InsRecMasterId { get; set; }
        public int InsuranceCompayId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string Term { get; set; }
        public string SumAssured { get; set; }
        public double Premium { get; set; }
    }

    public class InsuranceRecomendationTransaction
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int? CId { get; set; }
        public int? SpouseId { get; set; }
        public string Name { get; set; }
        public string SumAssured { get; set; }
        public string Description { get; set; }
        public List<InsuranceRecomendationDetail> InsuranceRecomendationDetails { get; set; }
    }
}
