using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace FinancialPlanner.Common.Model
{
    public class EmailAttachment
    {
        Attachment _attachment;
        List<Attachment> _attachmentlst;
        public EmailAttachment()
        {
            _attachmentlst = new List<Attachment>();
        }
        public void Add(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("Invalid parameter");

            _attachment = new Attachment(filename);
            _attachment.Name = System.IO.Path.GetFileName(filename);
            _attachmentlst.Add(_attachment);
        }
        public void Remove(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("Invalid parameter");

            var attachments =  _attachmentlst.Where(i => i.Name == System.IO.Path.GetFileName(filename));
            foreach (Attachment attachment in attachments)
            {
                _attachmentlst.Remove(attachment);
            }           
        }
        public List<Attachment> GetAttachment()
        {
            return _attachmentlst;
        }
    }
}
