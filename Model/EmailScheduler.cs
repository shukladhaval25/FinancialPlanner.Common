using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class EmailScheduler : Base
    {
        private int _id;
        private int _articleGroupId;
        private string _articleGroupName;
        private int _emailSenderGroupId = 0;
        private string _emailSchedulerGoupName;
        private string _schedeuleTitle;
        private ScheduleOccurranceType _scheduleType;
        private string _scheduleDetail;
        private int? _monthDayInterval;
        private string _weekdays;
        private DateTime _startDateTime;
        private DateTime _nextRunDateTime;
        private bool _allowRepeat;
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }        
        public int ArticleGroupId
        {
            get { return _articleGroupId; }
            set { _articleGroupId = value; }
        }
        public string ArticleGroupName
        {
            get { return _articleGroupName; }
            set { _articleGroupName = value; }
        }

        public int EmailSenderGroupId
        {
            get { return _emailSenderGroupId; }
            set { _emailSenderGroupId = value; }
        }
        public string ScheduleTitle
        {
            get { return _schedeuleTitle; }
            set { _schedeuleTitle = value; }
        }
        public ScheduleOccurranceType ScheduleType
        {
            get { return _scheduleType; }
            set { _scheduleType = value; }
        }
        public string ScheduleDetail
        {
            get {
                string typeValue = string.Empty;
                if (ScheduleType == ScheduleOccurranceType.Daily)
                    typeValue = "day";
                else if (ScheduleType == ScheduleOccurranceType.Monthly)
                    typeValue = string.Format("month on {0} day", MonthDayInterval);
                else
                    typeValue = string.Format("week {0}",WeekDays);

                _scheduleDetail = string.Format("Every {0} at {1}", typeValue, StartDateTime.ToString("hh:mm tt"));
                return _scheduleDetail;
            }            
        }
        public int? MonthDayInterval
        {
            get { return _monthDayInterval; }
            set { _monthDayInterval = value; }
        }
        public string WeekDays
        {
            get { return _weekdays; }
            set { _weekdays = value; }
        }
        public DateTime StartDateTime
        {
            get { return _startDateTime; }
            set { _startDateTime = value; }
        }
        public DateTime NextRunDateTime
        {
            get { return _nextRunDateTime; }
            set { _nextRunDateTime = value; }
        }
        public bool AllowRepeat
        {
            get { return _allowRepeat; }
            set { _allowRepeat = value; }
        }
    }

    public enum ScheduleOccurranceType
    {
        Daily = 0,
        Monthly = 1,
        Weekly =2
    }
}
