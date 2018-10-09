using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Activities
    {
        private int _id;
        private string _eventDescription;
        private ActivityType _activityType;        
        private string _hostName;
        private string _userName;
        private DateTime _activityAt;
        private EntryStatus _entryType;
        private Source _source;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string EventDescription
        {
            get { return _eventDescription; }
            set { _eventDescription = value; }
        }
        public ActivityType ActivityTypeValue
        {
            get { return _activityType; }
            set { _activityType = value; }
        }
        public string HostName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }
        public DateTime ActivityAt
        {
            get { return _activityAt; }
            set { _activityAt = value; }
        }

        public EntryStatus EntryType
        {
            get { return _entryType; }
            set { _entryType = value; }
        }
        public Source SourceType
        {
            get { return _source; }
            set { _source = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
    }
}
