using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Expenses : Base
    {
        int _id;
        int _pid;
        string _itemCategory;
        string _item;
        ExpenseType _occuranceType;
        double _amount;
        private bool _eligibleForInsuranceCoverage;
        string _expStartYear;
        string _expEndYear;
        float _inflationRate;
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

        public string ItemCategory
        {
            get
            {
                return _itemCategory;
            }

            set
            {
                _itemCategory = value;
            }
        }

        public string Item
        {
            get
            {
                return _item;
            }

            set
            {
                _item = value;
            }
        }

        public ExpenseType OccuranceType
        {
            get
            {
                return _occuranceType;
            }

            set
            {
                _occuranceType = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public bool EligibleForInsuranceCoverage
        {
            get { return _eligibleForInsuranceCoverage; }
            set { _eligibleForInsuranceCoverage = value; }
        }

        public string ExpStartYear { get => _expStartYear; set => _expStartYear = value; }
        public string ExpEndYear { get => _expEndYear; set => _expEndYear = value; }
        public float InflationRate { get => _inflationRate; set => _inflationRate = value; }
        public string Description { get => _description; set => _description = value; }
    }
    public enum ExpenseType
    {
        Monthly = 0,
        Yearly =1
    }
}
