using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class TravelDetails
    {
        public int TravelDetailsID { get; set; }
        public bool isConference_Journal { get; set; }
        public string detailsOfConference { get; set; }
        public string conferenceURL { get; set; }
        public string conferenceLocation { get; set; }
        public int conferenceQuality { get; set; }
        public string qualityComments { get; set; }

        public string paperTitle { get; set; }
        public bool isPaperAccepted { get; set; }
        public bool isHERDCPoints { get; set; }
        public string travelJustification { get; set; }
        public bool isSpecialDuties { get; set; }
        public string PEPArrangements { get; set; }

        public DateTime conferenceStartDate { get; set; }
        public DateTime conferenceEndDate { get; set; }
        public DateTime travelStartDate { get; set; }
        public DateTime travelEndDate { get; set; }      
        
        
    }
}