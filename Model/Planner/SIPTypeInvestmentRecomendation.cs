using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class SIPTypeInvestmentRecomendation : Base
    {
        int id;
        int pid;
        int cid;
        int schemeId;
        string schemeName;
        double amount;
        string category;
        string chequeInFavourOff;
        string firstHolder;
        string secondHolder;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public int Cid { get => cid; set => cid = value; }
        public int SchemeId { get => schemeId; set => schemeId = value; }
        public string SchemeName { get => schemeName; set => schemeName = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Category { get => category; set => category = value; }
        public string ChequeInFavourOff { get => chequeInFavourOff; set => chequeInFavourOff = value; }
        public string FirstHolder { get => firstHolder; set => firstHolder = value; }
        public string SecondHolder { get => secondHolder; set => secondHolder = value; }
    }
}
