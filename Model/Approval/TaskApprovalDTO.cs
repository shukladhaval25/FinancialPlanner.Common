using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Approval
{
    public class ApprovalDTO
    {
        public int Id { get; set; }
        public int LinkedId { get; set; }
        public int RequestRaisedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public string AuthorisedUsersToApprove { get; set; }
        public ApprovalStatus Status { get; set; }
        public int? ActionTakenBy { get; set; }
        public DateTime? ActionTakenOn { get; set; }
        public string Description { get; set; }
        public ApprovalType ApprovalType { get; set; }
        public string RequestedBy { get; set; }
        public string ActionBy { get; set; }
        public string ItemId { get; set; }
    }

    public enum ApprovalStatus
    {
        WaitingForApproval = 0,
        Approve = 1,
        Reject = 2,
        Reassign = 3
    }

    public enum ApprovalType
    {
        All = 0,
        TaskByPass = 1,
        PlanLock = 2,
        Reassign = 3
    }
}
