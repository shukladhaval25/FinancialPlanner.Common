using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class LifeInsurance : Base
    {
        int _id;
        int _pid;
        string _applicant;
        string _branch;
        string _agent;
        DateTime _dateOfIssue;
        DateTime _maturityDate;
        string _company;
        string _policyName;
        string _policyNo;
        double _premium;
        int _terms;
        string _premiumPayTerm;
        double _sumAssured;
        string _status;
        string _modeOfPayment;
        string _moneyback;
        DateTime? _nextPremDate;
        double _accidentalDeathBenefit;
        string _type;
        string _appointee;
        string _nominee;
        string _relation;
        double _loanTaken;
        DateTime? _loanDate;
        string _balanceUnit;
        DateTime? _asOnDate;
        double _currentValue;
        double _ExpectedMaturityValue;
        string _rider1;
        double _rider1Amount;
        string _rider2;
        double _rider2Amount;
        string _remarks;
        string _attachmentPath;
        DateTime? _lastPremiumDate;

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

        public string Applicant
        {
            get
            {
                return _applicant;
            }

            set
            {
                _applicant = value;
            }
        }

        public string Branch
        {
            get
            {
                return _branch;
            }

            set
            {
                _branch = value;
            }
        }

        public string Agent
        {
            get
            {
                return _agent;
            }

            set
            {
                _agent = value;
            }
        }

        public DateTime DateOfIssue
        {
            get
            {
                return _dateOfIssue;
            }

            set
            {
                _dateOfIssue = value;
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

        public string Company
        {
            get
            {
                return _company;
            }

            set
            {
                _company = value;
            }
        }

        public string PolicyName
        {
            get
            {
                return _policyName;
            }

            set
            {
                _policyName = value;
            }
        }

        public string PolicyNo
        {
            get
            {
                return _policyNo;
            }

            set
            {
                _policyNo = value;
            }
        }

        public double Premium
        {
            get
            {
                return _premium;
            }

            set
            {
                _premium = value;
            }
        }

        public int Terms
        {
            get
            {
                return _terms;
            }

            set
            {
                _terms = value;
            }
        }

        public string PremiumPayTerm
        {
            get
            {
                return _premiumPayTerm;
            }

            set
            {
                _premiumPayTerm = value;
            }
        }

        public double SumAssured
        {
            get
            {
                return _sumAssured;
            }

            set
            {
                _sumAssured = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string ModeOfPayment
        {
            get
            {
                return _modeOfPayment;
            }

            set
            {
                _modeOfPayment = value;
            }
        }

        public string Moneyback
        {
            get
            {
                return _moneyback;
            }

            set
            {
                _moneyback = value;
            }
        }

        public DateTime? NextPremDate
        {
            get
            {
                return _nextPremDate;
            }

            set
            {
                _nextPremDate = value;
            }
        }

        public double AccidentalDeathBenefit
        {
            get
            {
                return _accidentalDeathBenefit;
            }

            set
            {
                _accidentalDeathBenefit = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Appointee
        {
            get
            {
                return _appointee;
            }

            set
            {
                _appointee = value;
            }
        }

        public string Nominee
        {
            get
            {
                return _nominee;
            }

            set
            {
                _nominee = value;
            }
        }

        public string Relation
        {
            get
            {
                return _relation;
            }

            set
            {
                _relation = value;
            }
        }

        public double LoanTaken
        {
            get
            {
                return _loanTaken;
            }

            set
            {
                _loanTaken = value;
            }
        }

        public DateTime? LoanDate
        {
            get
            {
                return _loanDate;
            }

            set
            {
                _loanDate = value;
            }
        }

        public string BalanceUnit
        {
            get
            {
                return _balanceUnit;
            }

            set
            {
                _balanceUnit = value;
            }
        }

        public DateTime? AsOnDate
        {
            get
            {
                return _asOnDate;
            }

            set
            {
                _asOnDate = value;
            }
        }

        public double CurrentValue
        {
            get
            {
                return _currentValue;
            }

            set
            {
                _currentValue = value;
            }
        }

        public double ExpectedMaturityValue
        {
            get
            {
                return _ExpectedMaturityValue;
            }

            set
            {
                _ExpectedMaturityValue = value;
            }
        }

        public string Rider1
        {
            get
            {
                return _rider1;
            }

            set
            {
                _rider1 = value;
            }
        }

        public double Rider1Amount
        {
            get
            {
                return _rider1Amount;
            }

            set
            {
                _rider1Amount = value;
            }
        }

        public string Rider2
        {
            get
            {
                return _rider2;
            }

            set
            {
                _rider2 = value;
            }
        }

        public double Rider2Amount
        {
            get
            {
                return _rider2Amount;
            }

            set
            {
                _rider2Amount = value;
            }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string AttachmentPath
        {
            get
            {
                return _attachmentPath;
            }

            set
            {
                _attachmentPath = value;
            }
        }

        public DateTime? LastPremiumDate { get => _lastPremiumDate; set => _lastPremiumDate = value; }
    }
}
