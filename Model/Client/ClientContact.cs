using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ClientContact : Base
    {
        int _id;
        int _cid;
        string _add1;
        string _street;
        string _city;
        string _state;
        string _area;
        string _pin;
        string _email;
        string _spouseEmail;
        string _mobile;
        string _spousemobile;
        string _primaryEmail;
        string _primaryMobile;
        string _preferedPhoneCallMode;
        string _preferedContactTimeFrom;
        string _preferedContactTimeUpto;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public string Add1
        {
            get
            {
                return _add1;
            }

            set
            {
                _add1 = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string Pin
        {
            get
            {
                return _pin;
            }

            set
            {
                _pin = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string SpouseEmail
        {
            get
            {
                return _spouseEmail;
            }

            set
            {
                _spouseEmail = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _mobile;
            }

            set
            {
                _mobile = value;
            }
        }

        public string Spousemobile
        {
            get
            {
                return _spousemobile;
            }

            set
            {
                _spousemobile = value;
            }
        }

        public string PrimaryEmail
        {
            get
            {
                return _primaryEmail;
            }

            set
            {
                _primaryEmail = value;
            }
        }

        public string PrimaryMobile
        {
            get
            {
                return _primaryMobile;
            }

            set
            {
                _primaryMobile = value;
            }
        }

        public string Area
        {
            get
            {
                return _area;
            }

            set
            {
                _area = value;
            }
        }

        public string PreferedPhoneCallMode
        {
            get
            {
                return _preferedPhoneCallMode;
            }

            set
            {
                _preferedPhoneCallMode = value;
            }
        }

        public string PreferedContactTimeFrom
        {
            get
            {
                return _preferedContactTimeFrom;
            }

            set
            {
                _preferedContactTimeFrom = value;
            }
        }

        public string PreferedContactTimeUpto
        {
            get
            {
                return _preferedContactTimeUpto;
            }

            set
            {
                _preferedContactTimeUpto = value;
            }
        }
    }
}
