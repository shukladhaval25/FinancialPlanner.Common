using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ProspectClient : Base
    {
        private int _Id;
        private string _name;
        private string _phoneNo;
        private string _email;
        private string _occupation;
        private string _event;
        private DateTime _eventDate;
        private string _referedBy;
        private string _remarks;
        //private DateTime _createdOn;
        //private int _createdBy;
        //private DateTime _updatedOn;
        //private int _updatedBy;
        private string _updatedByUserName;
        private bool _isConvertedToClient;
        private bool _isStopSendingEmail;
        private IList<ProspectClientConversation> _lstProspectClientConversation;


        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }
        public string Event
        {
            get { return _event; }
            set { _event = value; }
        }
        public DateTime EventDate
        {
            get { return _eventDate; }
            set { _eventDate = value; }
        }
        public string ReferedBy
        {
            get { return _referedBy; }
            set { _referedBy = value; }
        }
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        public string UpdatedByUserName
        {
            get { return _updatedByUserName; }
            set { _updatedByUserName = value; }
        }
        public bool IsConvertedToClient
        {
            get { return _isConvertedToClient; }
            set { _isConvertedToClient = value; }
        }
        public bool StopSendingEmail
        {
            get { return _isStopSendingEmail; }
            set { _isStopSendingEmail = value; }
        }
        public IList<ProspectClientConversation> ProspectClientConversationList
        {
            get { return _lstProspectClientConversation; }
            set { _lstProspectClientConversation = value; }
        }
        public bool IntroductionCompleted { get; set; }
        public DateTime IntroductionCompletedDate { get; set; }
    }
}
