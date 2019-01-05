using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Masters
{
    public class OrganisationType : Base
    {
        int id;
        string type;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
