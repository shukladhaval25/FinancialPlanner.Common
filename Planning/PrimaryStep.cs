using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Planning
{
    public class PrimaryStep
    {
        public int Id { get; set; }
        public int StepNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int DurationInMinutes { get; set; }
        public int TimelineInDays { get; set; }
        public int? PrimaryResponsibility { get; set; }
        public int? Owner { get; set; }
        public int? Checker { get; set; }
    }

    public class LinkSubStep
    {
        public int Id { get; set; }
        public int PrimaryStepId { get; set; }
        public int StepNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int DurationInMinutes { get; set; }
        public int TimelineInDays { get; set; }
        public int? PrimaryResponsibility { get; set; }
        public int? Owner { get; set; }
        public int? Checker { get; set; }
    }

    public class ProcessStep : PrimaryStep
    {
        public List<LinkSubStep> LinkSubSteps { get; set; }
    }

    public class DesignationHierarchy
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string ReportTo { get; set; }
        public int? ReportingToDesignationId { get; set; }
        public string Description { get; set; }
    }
}
