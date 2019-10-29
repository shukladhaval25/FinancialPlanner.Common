using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.PlanOptions
{
    public class InvestmentRecommendation : Base
    {
        int id;
        int pid;
        int amcId;
        int schemeId;
        double amount;
        string category;
        string chequeInFavourOf;
        String firstHolder;
        String secondHolder;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public int AmcId { get => amcId; set => amcId = value; }
        public int SchemeId { get => schemeId; set => schemeId = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Category { get => category; set => category = value; }
        public string ChequeInFavourOf { get => chequeInFavourOf; set => chequeInFavourOf = value; }
        public string FirstHolder { get => firstHolder; set => firstHolder = value; }
        public string SecondHolder { get => secondHolder; set => secondHolder = value; }
    }
}
