using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class FreshPurchase : AdditionalPurchase
    {
        string secondHolder;
        string thirdHolder;
        string nominee;
        string guardian;

        public string SecondHolder { get => secondHolder; set => secondHolder = value; }
        public string ThirdHolder { get => thirdHolder; set => thirdHolder = value; }
        public string Nominee { get => nominee; set => nominee = value; }
        public string Guardian { get => guardian; set => guardian = value; }
    }
}
