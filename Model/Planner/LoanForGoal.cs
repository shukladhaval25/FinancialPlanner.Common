using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class LoanForGoal : Base
    {
        int _id;
        int _goalId;
        double _loanAmount;
        double _EMI;
        decimal _ROI;
        int _loanYears;
        int _stratYear;
        int _endYear;
        public int LoanPortion { get; set; }

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

        public int GoalId
        {
            get
            {
                return _goalId;
            }

            set
            {
                _goalId = value;
            }
        }

        public double LoanAmount
        {
            get
            {
                return _loanAmount;
            }

            set
            {
                _loanAmount = value;
            }
        }

        public double EMI
        {
            get
            {
                return _EMI;
            }

            set
            {
                _EMI = value;
            }
        }

        public decimal ROI
        {
            get
            {
                return _ROI;
            }

            set
            {
                _ROI = value;
            }
        }

        public int LoanYears
        {
            get
            {
                return _loanYears;
            }

            set
            {
                _loanYears = value;
            }
        }

        public int StratYear
        {
            get
            {
                return _stratYear;
            }

            set
            {
                _stratYear = value;
            }
        }

        public int EndYear
        {
            get
            {
                return _endYear;
            }

            set
            {
                _endYear = value;
            }
        }
    }
}
