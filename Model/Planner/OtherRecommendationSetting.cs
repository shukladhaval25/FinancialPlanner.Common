using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
   public class OtherRecommendationSetting
    {
        public int PID { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; }
        public string Description { get; set; }
    }
}
