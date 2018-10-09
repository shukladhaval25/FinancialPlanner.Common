using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class SalaryDetail : Base
    {
        int _id;
        int _incomeId;
        int _pid;
        double _ctc;
        double _reimbusement;
        double _employeePFContribution;
        double _employerPFContribution;
        double _superannuation;
        double _otherDeduction;
        double _netTakeHome;
        string _nextIncrementMonthYear;
        decimal  _expectedGrowthInPercentage;
        double _bonusAmt;
        string _bonusMonthYear;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int IncomeId
        {
            get
            {
                return _incomeId;
            }

            set
            {
                _incomeId = value;
            }
        }

        public int Pid
        {
            get
            {
                return _pid;
            }

            set
            {
                _pid = value;
            }
        }

        public double Ctc
        {
            get
            {
                return _ctc;
            }

            set
            {
                _ctc = value;
            }
        }

        public double Reimbursement
        {
            get { return _reimbusement; }
            set { _reimbusement = value; }
        }

        public double EmployeePFContribution
        {
            get
            {
                return _employeePFContribution;
            }

            set
            {
                _employeePFContribution = value;
            }
        }

        public double EmployerPFContribution
        {
            get
            {
                return _employerPFContribution;
            }

            set
            {
                _employerPFContribution = value;
            }
        }

        public double Superannuation
        {
            get
            {
                return _superannuation;
            }

            set
            {
                _superannuation = value;
            }
        }

        public double OtherDeduction
        {
            get
            {
                return _otherDeduction;
            }

            set
            {
                _otherDeduction = value;
            }
        }

        public double NetTakeHome
        {
            get
            {
                return _netTakeHome;
            }

            set
            {
                _netTakeHome = value;
            }
        }

        public string NextIncrementMonthYear
        {
            get
            {
                return _nextIncrementMonthYear;
            }

            set
            {
                _nextIncrementMonthYear = value;
            }
        }

        public decimal ExpectedGrowthInPercentage
        {
            get
            {
                return _expectedGrowthInPercentage;
            }

            set
            {
                _expectedGrowthInPercentage = value;
            }
        }

        public double BonusAmt
        {
            get
            {
                return _bonusAmt;
            }

            set
            {
                _bonusAmt = value;
            }
        }

        public string BonusMonthYear
        {
            get
            {
                return _bonusMonthYear;
            }

            set
            {
                _bonusMonthYear = value;
            }
        }
    }
}
