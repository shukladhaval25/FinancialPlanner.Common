using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class UserSession : Base
    {
        private int _id;
        private int _userId;
        private string _userToken;
        private DateTime _lastPingTime;
        private DateTime _expireOn;
        private const int SESSION_EXPIRATION_TIME_IN_MINUTES = 5;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserToken
        {
            get
            {
                return _userToken;
            }

            set
            {
                _userToken = value;
            }
        }

        public DateTime LastPingTime
        {
            get
            {
                return _lastPingTime;
            }

            set
            {
                _lastPingTime = value;
            }
        }

        public DateTime ExpireOn
        {
            get
            {
                return (_lastPingTime.AddMinutes(SESSION_EXPIRATION_TIME_IN_MINUTES));
            }            
        }

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
    }
}
