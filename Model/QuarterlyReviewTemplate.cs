using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class QuarterlyReviewTemplate : Base
    {
        int id;
        int cid;
        bool isSelected;
        string investmentType;
        bool isLoanSelected;

        public int Id { get => id; set => id = value; }
        public int Cid { get => cid; set => cid = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public string InvestmentType { get => investmentType; set => investmentType = value; }
        public bool IsLoanSelected { get => isLoanSelected; set => isLoanSelected = value; }
    }
}
