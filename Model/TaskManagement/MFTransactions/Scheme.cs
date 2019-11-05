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
        int amcId;
        string amcName;
        string name;
        int categoryId;
        string chequeInFavourOff;
        string type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int AmcId { get => amcId; set => amcId = value; }
        public string AmcName { get => amcName; set => amcName = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string ChequeInFavourOff { get => chequeInFavourOff; set => chequeInFavourOff = value; }
        public string Type { get => type; set => type = value; }
    }
}
