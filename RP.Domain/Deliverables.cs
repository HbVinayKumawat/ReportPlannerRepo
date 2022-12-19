using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain
{
    public class Deliverables
    {
        public int ReportId { get; set; }

        public int Id { get; set; }

        [Required]
        public string? Deliverable { get; set; }

        public Report? Report { get; set; }
    }
}
