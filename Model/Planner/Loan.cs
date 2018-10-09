using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Loan : Base
    {
        int _id;
        int _pid;
        string _typeOfLoan;
        double _outstandingAmt;
        int _emis;
        decimal _interestRate;
        int _termLeftInMonths;
        int _noEmisPayableUntilYear;
        string _description;

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

        public string TypeOfLoan
        {
            get
            {
                return _typeOfLoan;
            }

            set
            {
                _typeOfLoan = value;
            }
        }

        public double OutstandingAmt
        {
            get
            {
                return _outstandingAmt;
            }

            set
            {
                _outstandingAmt = value;
            }
        }

        public int Emis
        {
            get
            {
                return _emis;
            }

            set
            {
                _emis = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return _interestRate;
            }

            set
            {
                _interestRate = value;
            }
        }

        public int TermLeftInMonths
        {
            get
            {
                return _termLeftInMonths;
            }

            set
            {
                _termLeftInMonths = value;
            }
        }

        public int NoEmisPayableUntilYear
        {
            get
            {
                return _noEmisPayableUntilYear;
            }

            set
            {
                _noEmisPayableUntilYear = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
    }
}
