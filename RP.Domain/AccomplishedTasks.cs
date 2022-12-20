using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RP.Domain
{
    public class AccomplishedTasks
    {
        public int Id { get; set; }
        public int ReportId { get; set; }


        [Required]
        [Display(Name = "Accomplished Task")]
        public string? AccomplishedTask { get; set; }

        public Report? Report { get; set; }
      
    }
}
