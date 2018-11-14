using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class ClientFestivals : Base
    {
        int id;
        int cid;
        string festival;

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

        public int Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
            }
        }

        public string Festival
        {
            get
            {
                return festival;
            }

            set
            {
                festival = value;
            }
        }
    }
}
