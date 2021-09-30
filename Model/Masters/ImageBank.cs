using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.Masters
{
    public class ImageBank
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public string ImagePath { get; set; }
        public string ImageData { get; set; }
        public string Category { get; set; }
    }
}
