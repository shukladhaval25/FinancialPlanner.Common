using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Income : Base
    {
        int _id;
        int _pid;
        string _source;
        string _incomeBy;
        double _amount;
        decimal _expectGrowthInPercentage;
        string startYear;
        string endYear;
        string _description;
        float _incomeTax;
        SalaryDetail _salaryDetail;

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

        public string Source
        {
            get
            {
                return _source;
            }

            set
            {
                _source = value;
            }
        }

        public string IncomeBy
        {
            get
            {
                return _incomeBy;
            }

            set
            {
                _incomeBy = value;
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

        public decimal ExpectGrowthInPercentage
        {
            get
            {
                return _expectGrowthInPercentage;
            }

            set
            {
                _expectGrowthInPercentage = value;
            }
        }

        public string StartYear
        {
            get
            {
                return startYear;
            }

            set
            {
                startYear = value;
            }
        }

        public string EndYear
        {
            get
            {
                return endYear;
            }

            set
            {
                endYear = value;
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

        public SalaryDetail SalaryDetail
        {
            get
            {
                return _salaryDetail;
            }

            set
            {
                _salaryDetail = value;
            }
        }
        public float IncomeTax
        {
            get { return _incomeTax; }
            set { _incomeTax = value; }
        }
    }
}
