using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.PlanOptions
{
    public class CurrentStatusToGoal : Base
    {
        int _id;
        int _plannerId;
        int _optionId;
        int _goalId;
        double _fundAllocation;
        string _goalName;

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

        public int PlannerId
        {
            get
            {
                return _plannerId;
            }

            set
            {
                _plannerId = value;
            }
        }

        public int OptionId
        {
            get
            {
                return _optionId;
            }

            set
            {
                _optionId = value;
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

        public double FundAllocation
        {
            get
            {
                return _fundAllocation;
            }

            set
            {
                _fundAllocation = value;
            }
        }

        public string GoalName
        {
            get
            {
                return _goalName;
            }

            set
            {
                _goalName = value;
            }
        }
    }
}
