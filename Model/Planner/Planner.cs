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
        private int _accountManagedBy;
        private string _description;
        private bool _isDeleted = false;
        private string _reviewFrequency;
        public string Recommendation { get; set; }
        public string CurrencySymbol { get; set; }
        public float EquityRatio { get; set; }
        public float DebtRatio { get; set; }
        public string FaceType { get; set; }
        public bool  IsPlanLocked { get; set; }

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
            get { return _startDate.AddYears(1).AddDays(-1); }
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

        public int AccountManagedBy
        {
            get { return _accountManagedBy; }
            set { _accountManagedBy = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
        public string ReviewFrequency { get => _reviewFrequency; set => _reviewFrequency = value; }
    }
}
