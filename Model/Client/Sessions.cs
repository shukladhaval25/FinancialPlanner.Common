using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Sessions : Base
    {
        int clientId;
        string sessionName;
        DateTime sessionDate;
        bool isCoverd;
        string notes;

        public string SessionName { get => sessionName; set => sessionName = value; }
        public DateTime SessionDate { get => sessionDate; set => sessionDate = value; }
        public bool IsCoverd { get => isCoverd; set => isCoverd = value; }
        public string Notes { get => notes; set => notes = value; }
        public int ClientId { get => clientId; set => clientId = value; }
    }
}
