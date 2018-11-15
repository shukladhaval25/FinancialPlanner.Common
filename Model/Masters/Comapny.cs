using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Masters
{
    public class Company : Base
    {
        string name;
        string address;
        string contactno;
        string email;
        string website;
        string registrationNo;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Contactno
        {
            get
            {
                return contactno;
            }

            set
            {
                contactno = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Website
        {
            get
            {
                return website;
            }

            set
            {
                website = value;
            }
        }

        public string RegistrationNo
        {
            get
            {
                return registrationNo;
            }

            set
            {
                registrationNo = value;
            }
        }
    }
}
