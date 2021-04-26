using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class NetWorth : Base 
    {
        public int Id { get; set; }
        public int CId { get; set; }
        public int Year { get; set; }
        public double Amount { get; set; }
    }
}
