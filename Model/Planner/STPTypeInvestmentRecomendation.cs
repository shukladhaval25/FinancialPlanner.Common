using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class STPTypeInvestmentRecomendation : Base
    {
        int id;
        int pid;
        int cid;
        int fromSchemeId;
        string fromSchemeName;
        int schemeId;
        string schemeName;
        double amount;
        int duration;
        string frequency;
        double lumsumAmount;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public int Cid { get => cid; set => cid = value; }
        public int FromSchemeId { get => fromSchemeId; set => fromSchemeId = value; }
        public string FromSchemeName { get => fromSchemeName; set => fromSchemeName = value; }
        public int SchemeId { get => schemeId; set => schemeId = value; }
        public string SchemeName { get => schemeName; set => schemeName = value; }
        public double Amount { get => amount; set => amount = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public double LumsumAmount { get => lumsumAmount; set => lumsumAmount = value; }
    }
}
