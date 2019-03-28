using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class Bonds : Base
    {
        int _id;
        int _pid;
	    string _investerName;
        string _companyName;
        string _folioNo;
        float _rate;
        DateTime _maturityDate;
        int _noOfBond;
        float _faceValue;
        double _currentValue;
        int? _goalId;
        float _investmentReturnRate;

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

        public string InvesterName
        {
            get
            {
                return _investerName;
            }

            set
            {
                _investerName = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }

            set
            {
                _companyName = value;
            }
        }

        public string FolioNo
        {
            get
            {
                return _folioNo;
            }

            set
            {
                _folioNo = value;
            }
        }

        public float Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                _rate = value;
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

        public int NoOfBond
        {
            get
            {
                return _noOfBond;
            }

            set
            {
                _noOfBond = value;
            }
        }

        public float FaceValue
        {
            get
            {
                return _faceValue;
            }

            set
            {
                _faceValue = value;
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

        public int? GoalId
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

        public float InvestmentReturnRate
        {
            get
            {
                return _investmentReturnRate;
            }

            set
            {
                _investmentReturnRate = value;
            }
        }
    }
}
