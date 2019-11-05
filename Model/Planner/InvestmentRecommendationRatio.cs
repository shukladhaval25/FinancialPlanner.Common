using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class InvestmentRecommendationRatio : Base 
    {
        int id;
        int pid;
        double equityRatio;
        double debtRatio;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public double EquityRatio { get => equityRatio; set => equityRatio = value; }
        public double DebtRatio { get => debtRatio; set => debtRatio = value; }
    }
}
