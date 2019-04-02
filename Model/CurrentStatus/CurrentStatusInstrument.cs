using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class CurrentStatusInstrument
    {
        int _pid;
        string _instrumentName;
        Double _amount;
        float _roi;
        int _goalId;

        //IList<Tuple<string, double, float, int>> _instrumentsValueWithROI = new List<Tuple<string, double, float, int>>();
        //public void SetInstruments(string instumentName, double value, float roi, int goalid)
        //{
        //    _instrumentsValueWithROI.Add(new Tuple<string, double, float, int>(instumentName, value, roi, goalid));
        //}
        //public IList<Tuple<string, double, float, int>> GetInstruments()
        //{
        //    return _instrumentsValueWithROI;
        //}

        public int Pid
        {
            get
            {
                return _pid;
            }

            set
            {
                _pid = value;
            }
        }

        public string InstrumentName { get => _instrumentName; set => _instrumentName = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public float Roi { get => _roi; set => _roi = value; }
        public int GoalId { get => _goalId; set => _goalId = value; }
    }
}
