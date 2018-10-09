using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ClientEmployment : Base
    {
        int _id;
        int _cid;
        string _designation;
        string _employerName;
        string _address;
        string _street;
        string _city;        
        string _pin;
        string _income;

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

        public string EmployerName
        {
            get
            {
                return _employerName;
            }

            set
            {
                _employerName = value;
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

        public string Designation
        {
            get
            {
                return _designation;
            }

            set
            {
                _designation = value;
            }
        }

        public string Income
        {
            get
            {
                return _income;
            }

            set
            {
                _income = value;
            }
        }
    }
}
