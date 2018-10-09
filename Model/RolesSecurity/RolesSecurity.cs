using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.RolesSecurity
{
    public class RolesSecurity
    {
        int _id;
        int _RoleId;
        int _entityId;
        bool _allowAdd;
        bool _allowEdit;
        bool _allowDelete;
        bool _allowUpload;
    }
}
