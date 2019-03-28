using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class Shares : Base
    {       
        int _id;
        int _pid;
        string _investerName;
        string _companyName;
        float _faceValue = 0;
        int _noOfShares = 0;
        float _marketPrice = 0;
        double _currentValue;
        int? _goalID;
        string _firstHolder;
        string _secondHolder;
        string _nominee;
        float _investmentReturnRate = 0;

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

        public int NoOfShares
        {
            get
            {
                return _noOfShares;
            }

            set
            {
                _noOfShares = value;
            }
        }

        public float MarketPrice
        {
            get
            {
                return _marketPrice;
            }

            set
            {
                _marketPrice = value;
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

        public int? GoalID
        {
            get
            {
                return _goalID;
            }

            set
            {
                _goalID = value;
            }
        }

        public string FirstHolder
        {
            get
            {
                return _firstHolder;
            }

            set
            {
                _firstHolder = value;
            }
        }

        public string SecondHolder
        {
            get
            {
                return _secondHolder;
            }

            set
            {
                _secondHolder = value;
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

        public float InvestmentReturnRate
        {
            get { return _investmentReturnRate; }
            set { _investmentReturnRate = value; }
        }
    }
}
