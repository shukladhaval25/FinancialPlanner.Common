using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class MinutesOfMeeting
    {
        public int Id { get; set; }
        public DateTime MeetingDate { get; set; }
        public int ClientId { get; set; }
        public string Person { get; set; }
        public string MeetingType { get; set; }
        public List<MinutesOfMeetingDetails> MinutesOfMeetingDetails { get; set; }
    }
}
