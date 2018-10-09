using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class PlanOption : Base
    {
        int _id;
        int _pid;
        string _name;
        int _riskProfileId;

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

        public int RiskProfileId
        {
            get
            {
                return _riskProfileId;
            }

            set
            {
                _riskProfileId = value;
            }
        }
    }
}
