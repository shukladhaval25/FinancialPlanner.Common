using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Masters
{
    public class Bank :Base
    {
        int id;
        string name;
        string branch;
        string address;
        string city;
        string state;
        int? pincode;
        string ifsc;
        string micr;
        string country;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Branch { get => branch; set => branch = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public int? Pincode { get => pincode; set => pincode = value; }
        public string IFSC { get => ifsc; set => ifsc = value; }
        public string MICR { get => micr; set => micr = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
    }
}
