using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Masters
{
    public class Company : Base
    {
        int id;
        int otid;
        string name;
        string address;
        string contactno;
        string email;
        string website;
        string registrationNo;
        string gst;
        string bank;
        string accountno;
        string panno;

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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Otid
        {
            get
            {
                return otid;
            }

            set
            {
                otid = value;
            }
        }

        public string Gst
        {
            get
            {
                return gst;
            }

            set
            {
                gst = value;
            }
        }

        public string Bank
        {
            get
            {
                return bank;
            }

            set
            {
                bank = value;
            }
        }

        public string Accountno
        {
            get
            {
                return accountno;
            }

            set
            {
                accountno = value;
            }
        }

        public string Panno
        {
            get
            {
                return panno;
            }

            set
            {
                panno = value;
            }
        }
    }
}
