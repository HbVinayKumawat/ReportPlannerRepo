using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain
{
    internal class InteractionMethods
    {
        public int ReportId { get; set; }

        public int Id { get; set; }

        //[Required]
        //public InteractionMethod InteractionMethod { get; set; }
        [Required]
        public int InteractionCount { get; set; }

        public Report? Report { get; set; }
    }
    //public enum InteractionMethod { VideoCall, TextMessaging, Email, InstaConnect }

    
}
