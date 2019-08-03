using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class ARN : Base
    {
        int id;
        string arnNumber;
        string name;

        public int Id { get => id; set => id = value; }
        public string ArnNumber { get => arnNumber; set => arnNumber = value; }
        public string Name { get => name; set => name = value; }
    }
}
