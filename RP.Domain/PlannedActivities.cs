using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RP.Domain
{
    public class PlannedActivities
    {
        public int ReportId { get; set; }

        public int Id { get; set; }

        [Required]
        public string? Activity { get; set; }

        public decimal Hours { get; set; }

        public int Resources { get; set; }

        [Required]
        [Display(Name = "Activity Status")]
        public ActivityStatus ActivityStatus { get; set; }

        public Report? Report { get; set; }
    }
    public enum ActivityStatus { InProgress, Completed }
}
