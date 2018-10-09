﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Goals : Base
    {
        int _id;
        int _pid;
        string _category;
        string _name;
        double _amount;
        string _startYear;
        string _endYear;
        int? __recurrence;
        int _priority;
        string _description;
        decimal _inflationRate;
        LoanForGoal _loanForGoal;
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

        public string Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
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

        public string StartYear
        {
            get
            {
                return _startYear;
            }

            set
            {
                _startYear = value;
            }
        }

        public string EndYear
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

        public int? Recurrence
        {
            get
            {
                return __recurrence;
            }

            set
            {
                __recurrence = value;
            }
        }

        public int Priority
        {
            get
            {
                return _priority;
            }

            set
            {
                _priority = value;
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

        public decimal InflationRate
        {
            get
            {
                return _inflationRate;
            }

            set
            {
                _inflationRate = value;
            }
        }

        public LoanForGoal LoanForGoal
        {
            get
            {
                return _loanForGoal;
            }

            set
            {
                _loanForGoal = value;
            }
        }
    }
}