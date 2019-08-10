using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class Scheme : Base
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
