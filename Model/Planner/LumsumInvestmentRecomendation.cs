using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class LumsumInvestmentRecomendation :Base
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
        string thirdHolder;
        string type;
        string amc;
        string nominee;

        public int Pid { get => pid; set => pid = value; }
        public int Cid { get => cid; set => cid = value; }
        public int SchemeId { get => schemeId; set => schemeId = value; }
        public double Amount { get => amount; set => amount = value; }
        public string ChequeInFavourOff { get => chequeInFavourOff; set => chequeInFavourOff = value; }
        public string FirstHolder { get => firstHolder; set => firstHolder = value; }
        public string SecondHolder { get => secondHolder; set => secondHolder = value; }
        public string ThirdHolder { get => thirdHolder; set => thirdHolder = value; }
        public int Id { get => id; set => id = value; }
        public string SchemeName { get => schemeName; set => schemeName = value; }
        public string Category { get => category; set => category = value; }
        public string Type { get => type; set => type = value; }
        public string AMC { get => amc; set => amc = value; }
        public string Nominee { get => nominee; set => nominee = value; }
    }
}
