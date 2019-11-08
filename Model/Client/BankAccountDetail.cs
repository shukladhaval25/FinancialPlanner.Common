using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class BankAccountDetail : Base
    {
        int _id;
        int _cid;
        int _accountHolderId;
        string _bankName;
        string _accountType;
        string _accountNo;
        string _address;
        string _contactNo;
        bool _isJoinAccount;
        string _joinHolderName;
        double _minRequireBalance;
        int _bankAccountId;

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

        public int AccountHolderID
        {
            get
            {
                return _accountHolderId;
            }

            set
            {
                _accountHolderId = value;
            }
        }

        public string BankName
        {
            get
            {
                return _bankName;
            }

            set
            {
                _bankName = value;
            }
        }

        public string AccountType
        {
            get
            {
                return _accountType;
            }

            set
            {
                _accountType = value;
            }
        }

        public string AccountNo
        {
            get
            {
                return _accountNo;
            }

            set
            {
                _accountNo = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string ContactNo
        {
            get
            {
                return _contactNo;
            }

            set
            {
                _contactNo = value;
            }
        }

        public bool IsJoinAccount
        {
            get
            {
                return _isJoinAccount;
            }

            set
            {
                _isJoinAccount = value;
            }
        }

        public string JoinHolderName
        {
            get
            {
                return _joinHolderName;
            }

            set
            {
                _joinHolderName = value;
            }
        }

        
        public double MinRequireBalance
        {
            get
            {
                return _minRequireBalance;
            }

            set
            {
                _minRequireBalance = value;
            }
        }

        public int BankId { get => _bankAccountId; set => _bankAccountId = value; }
    }
}
