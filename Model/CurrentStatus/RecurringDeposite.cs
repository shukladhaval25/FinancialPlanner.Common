using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class RecurringDeposit : FixedDeposit
    {
        double _monthlyInstallment;

        public double MonthlyInstallment
        {
            get
            {
                return _monthlyInstallment;
            }

            set
            {
                _monthlyInstallment = value;
            }
        }
    }
}
