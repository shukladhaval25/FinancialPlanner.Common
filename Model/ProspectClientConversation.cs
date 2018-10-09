using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ProspectClientConversation : Base
    {
        private int _id;
        private int _prospectClientId;
        private DateTime _conversationDate;
        private string _conversationBy;
        private string _remarks;
        //private DateTime _createdOn;
        //private int _createdBy;
        //private DateTime _updatedOn;
        //private int _updatedBy;
        private string _updatedByUserName;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ProspectClientId
        {
            get { return _prospectClientId; }
            set { _prospectClientId = value; }
        }
        public DateTime ConversationDate
        {
            get { return _conversationDate; }
            set { _conversationDate = value; }
        }
        public string ConversationBy
        {
            get { return _conversationBy; }
            set { _conversationBy = value; }
        }
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        //public DateTime CreatedOn
        //{
        //    get { return _createdOn; }
        //    set { _createdOn = value; }
        //}

        //public int CreatedBy
        //{
        //    get { return _createdBy; }
        //    set { _createdBy = value; }
        //}

        //public DateTime UpdatedOn
        //{
        //    get { return _updatedOn; }
        //    set { _updatedOn = value; }
        //}

        //public int UpdatedBy
        //{
        //    get { return _updatedBy; }
        //    set { _updatedBy = value; }
        //}
       
        public string UpdatedByUserName
        {
            get { return _updatedByUserName; }
            set { _updatedByUserName = value; }
        }
    }
}
