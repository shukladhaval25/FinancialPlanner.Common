using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class EmailGroup
    {
        private int _id;
        private string _name;
        private List<EmailArticle> _emailArticles;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<EmailArticle> EmailArticles
        {
            get { return _emailArticles; }            
            set { _emailArticles = value; }
        }
    }
}
