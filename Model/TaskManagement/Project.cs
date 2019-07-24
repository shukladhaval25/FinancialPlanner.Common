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
        string initialId;
        string description;
        bool isCustomType = true;
        public int Id { get; set; }
        public string Name { get; set; }
        public string InitialId { get => initialId; set => initialId = value; }
        public string Description { get => description; set => description = value; }
        public bool IsCustomType { get => isCustomType; set => isCustomType = value; }
    }
}
