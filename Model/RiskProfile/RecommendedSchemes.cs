using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.RiskProfile
{
    public class RecommendedSchemes : Base
    {
        int _id;
        int _investmentSegmentID;
        string _schemeName;

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

        public int InvestmentSegmentID
        {
            get
            {
                return _investmentSegmentID;
            }

            set
            {
                _investmentSegmentID = value;
            }
        }

        public string SchemeName
        {
            get
            {
                return _schemeName;
            }

            set
            {
                _schemeName = value;
            }
        }
    }
}
