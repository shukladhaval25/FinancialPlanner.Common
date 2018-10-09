using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class PlannerSessions : Base
    {
        int _id;
        int _pid;
        string _topic;
        DateTime _sessionDate;
        bool _sessionCovered;
        string _notes;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Pid
        {
            get
            {
                return _pid;
            }

            set
            {
                _pid = value;
            }
        }

        public string Topic
        {
            get
            {
                return _topic;
            }

            set
            {
                _topic = value;
            }
        }

        public DateTime SessionDate
        {
            get
            {
                return _sessionDate;
            }

            set
            {
                _sessionDate = value;
            }
        }

        public bool SessionCovered
        {
            get
            {
                return _sessionCovered;
            }

            set
            {
                _sessionCovered = value;
            }
        }

        public string Notes
        {
            get
            {
                return _notes;
            }

            set
            {
                _notes = value;
            }
        }
    }
}
