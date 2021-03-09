using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.PlanOptions
{
    public class ContingencyFund : Base 
    {
        int _id;
        int _plannerId;
        int _optionId;
        double _amount;

        public int Id { get => _id; set => _id = value; }
        public int PlannerId { get => _plannerId; set => _plannerId = value; }
        public int OptionId { get => _optionId; set => _optionId = value; }
        public double Amount { get => _amount; set => _amount = value; }
    }
}
