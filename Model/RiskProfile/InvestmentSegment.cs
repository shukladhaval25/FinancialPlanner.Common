using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.RiskProfile
{
    public class InvestmentSegment : Base
    {
        int _id;
        int _riskProfileId;
        string _investmentType;
        string _segmentName;
        float _segmentRatio;

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

        public string InvestmentType
        {
            get
            {
                return _investmentType;
            }

            set
            {
                _investmentType = value;
            }
        }

        public string SegmentName
        {
            get
            {
                return _segmentName;
            }

            set
            {
                _segmentName = value;
            }
        }

        public float SegmentRatio
        {
            get
            {
                return _segmentRatio;
            }

            set
            {
                _segmentRatio = value;
            }
        }
    }
}
