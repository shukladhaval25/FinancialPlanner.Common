using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class FixedDeposit : BankAccount
    {        
        double _maturityAmt;
        DateTime _depositDate;
        DateTime _maturityDate;       

        public double MaturityAmt
        {
            get
            {
                return _maturityAmt;
            }

            set
            {
                _maturityAmt = value;
            }
        }

        public DateTime DepositDate
        {
            get
            {
                return _depositDate;
            }

            set
            {
                _depositDate = value;
            }
        }

        public DateTime MaturityDate
        {
            get
            {
                return _maturityDate;
            }

            set
            {
                _maturityDate = value;
            }
        }
    }
}
