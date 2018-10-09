using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public abstract class Base
    {
        private DateTime _createdOn;
        private DateTime _updatedOn;
        private int _createdBy;
        private int _updatedBy;

        private string _updatedByUserName;
        private string _hostName;

        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        public DateTime UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }
        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public int UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }
        public string MachineName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }
        public string UpdatedByUserName
        {
            get { return _updatedByUserName; }
            set { _updatedByUserName = value; }
        }
    }
}
