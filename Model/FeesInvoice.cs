using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common
{
    public class FeesInvoice
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CId { get; set; }
    }

    public class FeesInvoiceDetail
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string Particulars { get; set; }
        public double Amount { get; set; }
    }

    public class FeesInvoiceTransacation
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CId { get; set; }
        public List<FeesInvoiceDetail> feesInvoiceDetails { get; set; }
    }
}
