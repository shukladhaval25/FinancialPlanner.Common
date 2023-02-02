using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class MOM
    {
        public int MId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingType { get; set; }
        public int CId { get; set; }
        public bool MarkAsImportant { get; set; }
        public string Duration { get; set; }
        public string Notes { get; set; }
       
    }

    public class MOMPoint
    {
        public int Id { get; set; }
        public int MId { get; set; }
        public string DiscussedPoint { get; set; }
        public string FutureAction { get; set; }
        public string Responsibility { get; set; }
        public int EmpId { get; set; }
        public string TaskId { get; set; }
        public string TaskStatus { get; set; }
        public string UserName { get; set; }
    }

    public class MOMTransaction
    {

        public int MId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingType { get; set; }
        public int CId { get; set; }
        public bool MarkAsImportant { get; set; }
        public string Duration { get; set; }
        public string Notes { get; set; }
        public DateTime? EmailSendDate { get; set; }
        public List<MOMPoint> MOMPoints { get; set; }
    }
}
