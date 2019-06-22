using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.ProcessAction
{
    public class PlannerProcess
    {
        private string processImagePath;
        string imageData;
        string action;
        string step;
        int stepNo;
        int estimatedDaysToComplete;
        bool isDelay;
        bool isVarificationRequireBySenior;
        string description;

        public string ProcessImagePath { get => processImagePath; set => processImagePath = value; }
        public string Action { get => action; set => action = value; }
        public string Step { get => step; set => step = value; }
        public int StepNo { get => stepNo; set => stepNo = value; }
        public int EstimatedDaysToComplete { get => estimatedDaysToComplete; set => estimatedDaysToComplete = value; }
        public bool IsDelay { get => isDelay; set => isDelay = value; }
        public string Description { get => description; set => description = value; }
        public bool IsVarificationRequireBySenior { get => isVarificationRequireBySenior; set => isVarificationRequireBySenior = value; }
        public string ImageData { get => imageData; set => imageData = value; }
    }
}
