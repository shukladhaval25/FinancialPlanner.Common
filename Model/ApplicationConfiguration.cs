using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ApplicationConfiguration : Base
    {
        private int _id;
        private string _category;
        private string _settingName;
        private string _settingValue;
        //private DateTime _createdOn;
        //private DateTime _updatedOn;
        //private int _createdBy;
        //private int _updatedBy;
        private string _createdByUserName;
        private string _updatedByUserName;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string SettingName
        {
            get { return _settingName; }
            set { _settingName = value;}
        }

        public string SettingValue
        {
            get { return _settingValue; }
            set { _settingValue = value; }
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

        // public int UpdatedBy
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
