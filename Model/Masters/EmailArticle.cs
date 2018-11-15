using System.Collections.Generic;
using System.Net.Mail;

namespace FinancialPlanner.Common.Model
{
    public class EmailArticle : Base
    {
        private int _id;
        private int _groupId = 0;
        private string _title;
        private string _contentFilePath;
        private string _description;
        private List<Attachment> _attachmentlst;
        private string _groupName;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string ContentFilePath
        {
            get { return _contentFilePath; }
            set { _contentFilePath = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public List<Attachment> Attachments
        {
            get { return _attachmentlst; }
            set { _attachmentlst = value; }
        }
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
    }
}
