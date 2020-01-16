using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class SwitchTypeInvestmentRecommendation : Base
    {
        int id;
        int pid;
        int cid;
        int fromSchemeId;
        string fromSchemeName;
        int toSchemeId;
        string toSschemeName;
        double amount;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public int Cid { get => cid; set => cid = value; }
        public int FromSchemeId { get => fromSchemeId; set => fromSchemeId = value; }
        public string FromSchemeName { get => fromSchemeName; set => fromSchemeName = value; }
        public int ToSchemeId { get => toSchemeId; set => toSchemeId = value; }
        public string ToSchemeName { get => toSschemeName; set => toSschemeName = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
