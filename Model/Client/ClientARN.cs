using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ClientARN
    {
        int id;
        int cid;
        int arnid;
        string arnName;
        string arnNumber;

        public int Id { get => id; set => id = value; }
        public int Cid { get => cid; set => cid = value; }
        public int ARNId { get => arnid; set => arnid = value; }
        public string ARNName { get => arnName; set => arnName = value; }
        public string ArnNumber { get => arnNumber; set => arnNumber = value; }
    }
}
