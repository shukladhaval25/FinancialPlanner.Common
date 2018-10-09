using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.PlanOptions
{
    public class CashFlow : Base
    {
        int _id;
        int _oid;
        float _incomeTax;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Oid
        {
            get
            {
                return _oid;
            }

            set
            {
                _oid = value;
            }
        }

        public float IncomeTax
        {
            get
            {
                return _incomeTax;
            }

            set
            {
                _incomeTax = value;
            }
        }
    }
}
