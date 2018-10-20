using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class NonFinancialAsset : Base
    {
        int _id;
        int _pid;
        int _cid;
        string _name;
        double _currentValue;
        int _primaryholderShare;
        int _secondaryHolderShare;
        string _otherHolderName;
        int _otherHolderShare;
        int? _mappedGoalId;
        int _assetMappingShare;
        string _assetRealisationYear;
        string _descryption;
        decimal _growthPercentage;

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

        public int Cid
        {
            get
            {
                return _cid;
            }

            set
            {
                _cid = value;
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

        public int PrimaryholderShare
        {
            get
            {
                return _primaryholderShare;
            }

            set
            {
                _primaryholderShare = value;
            }
        }

        public int SecondaryHolderShare
        {
            get
            {
                return _secondaryHolderShare;
            }

            set
            {
                _secondaryHolderShare = value;
            }
        }

        public string OtherHolderName
        {
            get
            {
                return _otherHolderName;
            }

            set
            {
                _otherHolderName = value;
            }
        }

        public int OtherHolderShare
        {
            get
            {
                return _otherHolderShare;
            }

            set
            {
                _otherHolderShare = value;
            }
        }

        public int? MappedGoalId
        {
            get
            {
                return _mappedGoalId;
            }

            set
            {
                _mappedGoalId = value;
            }
        }

        public int AssetMappingShare
        {
            get
            {
                return _assetMappingShare;
            }

            set
            {
                _assetMappingShare = value;
            }
        }

        public string AssetRealisationYear
        {
            get
            {
                return _assetRealisationYear;
            }

            set
            {
                _assetRealisationYear = value;
            }
        }

        public string Description
        {
            get
            {
                return _descryption;
            }

            set
            {
                _descryption = value;
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

        public decimal GrowthPercentage
        {
            get
            {
                return _growthPercentage;
            }

            set
            {
                _growthPercentage = value;
            }
        }
    }
}
