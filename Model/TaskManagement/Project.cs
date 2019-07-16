using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement
{
    public class Project : Base
    {
        int id;
        string name;
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
