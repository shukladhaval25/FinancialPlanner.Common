using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class MFTransactions: Base
    {
        int _id;
        int _MFId;
        float _nav = 0;
        int _units = 0;
        double _currentValue = 0;
        string _transactionType;
        DateTime _transactionDate;

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

        public int MFId
        {
            get
            {
                return _MFId;
            }

            set
            {
                _MFId = value;
            }
        }

        public float Nav
        {
            get
            {
                return _nav;
            }

            set
            {
                _nav = value;
            }
        }

        public int Units
        {
            get
            {
                return _units;
            }

            set
            {
                _units = value;
            }
        }

        public double CurrentValue
        {
            get
            {
                return _nav * _units;
            }
        }

        public string TransactionType
        {
            get
            {
                return _transactionType;
            }

            set
            {
                _transactionType = value;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _transactionDate;
            }

            set
            {
                _transactionDate = value;
            }
        }
    }
}
