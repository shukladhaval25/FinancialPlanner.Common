using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class PlannerAssumption : Base
    {
        int _id;
        int _pid;
        int _clientRetirementAge;
        int _spouseRetirementAge;
        int _clientLifeExpectancy;
        int _spouseLifeExpectancy;
        decimal _preRetirementInflactionRate;
        decimal _postRetirementInflactionRate;
        decimal _equityReturnRate;
        decimal _debtReturnRate;
        decimal _otherReturnRate;
        string _decription;
        bool _isClientRetirmentAgeIsPrimary;
        decimal _clientIncomeRise;
        decimal _spouseIncomeRise;
        decimal _ongoingExpRise;

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

        public int ClientRetirementAge
        {
            get
            {
                return _clientRetirementAge;
            }

            set
            {
                _clientRetirementAge = value;
            }
        }

        public int SpouseRetirementAge
        {
            get
            {
                return _spouseRetirementAge;
            }

            set
            {
                _spouseRetirementAge = value;
            }
        }

        public int ClientLifeExpectancy
        {
            get
            {
                return _clientLifeExpectancy;
            }

            set
            {
                _clientLifeExpectancy = value;
            }
        }

        public int SpouseLifeExpectancy
        {
            get
            {
                return _spouseLifeExpectancy;
            }

            set
            {
                _spouseLifeExpectancy = value;
            }
        }

        public decimal PreRetirementInflactionRate
        {
            get
            {
                return _preRetirementInflactionRate;
            }

            set
            {
                _preRetirementInflactionRate = value;
            }
        }

        public decimal PostRetirementInflactionRate
        {
            get
            {
                return _postRetirementInflactionRate;
            }

            set
            {
                _postRetirementInflactionRate = value;
            }
        }

        public decimal EquityReturnRate
        {
            get
            {
                return _equityReturnRate;
            }

            set
            {
                _equityReturnRate = value;
            }
        }

        public decimal DebtReturnRate
        {
            get
            {
                return _debtReturnRate;
            }

            set
            {
                _debtReturnRate = value;
            }
        }

        public decimal OtherReturnRate
        {
            get
            {
                return _otherReturnRate;
            }

            set
            {
                _otherReturnRate = value;
            }
        }

        public string Decription
        {
            get
            {
                return _decription;
            }

            set
            {
                _decription = value;
            }
        }

        public bool IsClientRetirmentAgeIsPrimary { get => _isClientRetirmentAgeIsPrimary; set => _isClientRetirmentAgeIsPrimary = value; }
        public decimal ClientIncomeRise { get => _clientIncomeRise; set => _clientIncomeRise = value; }
        public decimal SpouseIncomeRise { get => _spouseIncomeRise; set => _spouseIncomeRise = value; }
        public decimal OngoingExpRise { get => _ongoingExpRise; set => _ongoingExpRise = value; }
    }
}
