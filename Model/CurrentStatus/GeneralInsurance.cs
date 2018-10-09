using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class GeneralInsurance : Base
    {
        int _id;
        int _pid;
        string _applicant;
        DateTime? _issueDate;
        int _termsInYears;
        DateTime? _maturityDate;
        string _policyNo;
        string _compnay;
        string _policy;
        string _type;
	    double _sumAssured;
        double _bonus;
        double _premium;
        string _remark;
        string _attachmentPath;

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

        public string Applicant
        {
            get
            {
                return _applicant;
            }

            set
            {
                _applicant = value;
            }
        }

        public DateTime? IssueDate
        {
            get
            {
                return _issueDate;
            }

            set
            {
                _issueDate = value;
            }
        }

        public int TermsInYears
        {
            get
            {
                return _termsInYears;
            }

            set
            {
                _termsInYears = value;
            }
        }

        public DateTime? MaturityDate
        {
            get
            {
                return _maturityDate;
            }

            set
            {
                _maturityDate = value;
            }
        }

        public string PolicyNo
        {
            get
            {
                return _policyNo;
            }

            set
            {
                _policyNo = value;
            }
        }

        public string Company
        {
            get
            {
                return _compnay;
            }

            set
            {
                _compnay = value;
            }
        }

        public string Policy
        {
            get
            {
                return _policy;
            }

            set
            {
                _policy = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public double SumAssured
        {
            get
            {
                return _sumAssured;
            }

            set
            {
                _sumAssured = value;
            }
        }

        public double Bonus
        {
            get
            {
                return _bonus;
            }

            set
            {
                _bonus = value;
            }
        }

        public double Premium
        {
            get
            {
                return _premium;
            }

            set
            {
                _premium = value;
            }
        }

        public string Remark
        {
            get
            {
                return _remark;
            }

            set
            {
                _remark = value;
            }
        }

        public string AttachmentPath
        {
            get
            {
                return _attachmentPath;
            }

            set
            {
                _attachmentPath = value;
            }
        }
    }
}
