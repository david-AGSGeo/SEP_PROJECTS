using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class TravelDetails
    {
        //public int TravelDetailsID { get; set; }
        [Display(Name = "Are You presenting a Journal Article")]
        public bool isConference_Journal { get; set; }
        [Display(Name = "Conference Details")]
        public string detailsOfConference { get; set; }
        [Display(Name = "Conference website URL")]
        public string conferenceURL { get; set; }
        [Display(Name = "Location of conference")]
        public string conferenceLocation { get; set; }
        [Display(Name = "Conference Quality (High, Medium, or Low)")]
        public int conferenceQuality { get; set; }
        [Display(Name = "Any Comments on the quality")]
        public string qualityComments { get; set; }

        [Display(Name = "Title of your paper")]
        public string paperTitle { get; set; }
        [Display(Name = "Has your paper been accepted?")]
        public bool isPaperAccepted { get; set; }
        [Display(Name = "Are HERDC points applicable to your paper")]
        public bool isHERDCPoints { get; set; }
        [Display(Name = "What is your Travel Justification")]
        public string travelJustification { get; set; }
        [Display(Name = "Will you be performing any special duties?")]
        public bool isSpecialDuties { get; set; }
        [Display(Name = "Do you have any PEP arrangements")]
        public bool PEPArrangements { get; set; }

        [Display(Name = "What date does the conference start?")]
        public DateTime conferenceStartDate { get; set; }
        [Display(Name = "What date does the conference end?")]
        public DateTime conferenceEndDate { get; set; }
        [Display(Name = "Start date of travel")]
        public DateTime travelStartDate { get; set; }
        [Display(Name = "End date of travel")]
        public DateTime travelEndDate { get; set; }      
        
        
    }
}