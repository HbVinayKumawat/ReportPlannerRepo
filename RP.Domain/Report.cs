using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RP.Domain
{
    public class Report
    {
        public int ReportId { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        public string? ProjectName { get; set; }
        
        [Required]
        [Display(Name = "Project Code")]
        public string? ProjectCode { get; set; }

        [Required]
        [Display(Name = "Project Type")]
        public string? ProjectType { get; set; }

        [Required]
        [Display(Name = "Added By")]
        public string? AddedBy { get; set; }

        [Display(Name = "Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Assigned Resources")]
        public int AssignedResources { get; set; }
       
        [Display(Name = "Report Period")]
        public ReportType ReportPeriod { get; set; }

        [Required]
        public Months Month { get; set; }

        [Required]
        public Week Week { get; set; }

        public DateTime Date { get; set; }        

        public InteractionMethod Interaction { get; set; }

        [Display(Name = "Interaction Count")]
        public int InteractionCount { get; set; }

        public Member Members { get; set; }

        [Display(Name = "Members Count")]
        public int MembersCount { get; set; }

        public List<Deliverables>? Deliverables { get; set; }

        [Display(Name = "Accomplished Tasks")]
        public List<AccomplishedTasks>? AccomplishedTasks { get; set; }

        [Display(Name = "Planned Activities")]
        public List<PlannedActivities>? PlannedActivities { get; set; }
    }
    public enum InteractionMethod { VideoCall, TextMessaging, Email, InstaConnect }
    public enum Member { ProjectManager, BusinessAnalyst, FunctionalAnalyst }
    public enum ReportType { Weekly, BiWeekly, Monthly }
    public enum Months { January, February, March, April, May, June, July, August, September, October, November, December }
    public enum Week { Week1, Week2, Week3, Week4 }
}
