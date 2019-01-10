using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Planner : Base
    {
        private int _id;
        private int _cid;
        private string _name;
        private DateTime _startDate;
        private int _plannerStartMonth;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ClientId
        {
            get { return _cid; }
            set { _cid = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _startDate.AddYears(1); }
        }
        public bool IsActive
        {
            get {
                return (DateTime.Now.Date >= StartDate && 
                    DateTime.Now.Date <= EndDate);
            }
        }
        public int PlannerStartMonth
        {
            get { return _plannerStartMonth; }
            set { _plannerStartMonth = value; }
        }
        public int PlannerEndMonth
        {
            get
            {
                DateTime strDate = new DateTime(2000, _plannerStartMonth, 1); // monthNum is your input
                return strDate.AddMonths(-1).Month;
            }
        }
    }
}
