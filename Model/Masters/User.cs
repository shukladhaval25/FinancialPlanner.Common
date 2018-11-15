using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class User : Base
    {
        private int _id;
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _pwd;
        //private DateTime _createdOn;
        //private int _createdBy;
        //private DateTime _updatedOn;
        //private int _updatedBy;
        private string _createdByUserName;
        private string _updatedByUserName;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }


        //public DateTime CreatedOn
        //{
        //    get { return _createdOn; }
        //    set { _createdOn = value; }
        //}

        //public int CreatedBy
        //{
        //    get { return _createdBy; }
        //    set { _createdBy = value; }
        //}

        //public DateTime UpdatedOn
        //{
        //    get { return _updatedOn; }
        //    set { _updatedOn = value; }
        //}

        //public int UpdatedBy
        //{
        //    get { return _updatedBy; }
        //    set { _updatedBy = value; }
        //}

        public string CreatedByUserName
        {
            get { return _createdByUserName; }
            set { _createdByUserName = value; }
        }

        public string UpdatedByUserName
        {
            get { return _updatedByUserName; }
            set { _updatedByUserName = value; }
        }
    }
}
