using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class FundingDetails
    {
        //public int FundingDetailsId { get; set; }
        [Display(Name = "Type of research performed")]
        public string researchType { get; set; }
        [Display(Name = "Strength of research performes")]
        public string researchStrength { get; set; }
        [Display(Name = "Will you be recieving Travel Support?")]
        public bool travelSupport { get; set; }
        [Display(Name = "at what stage is your funding?")]
        public int fundingStage { get; set; }
        [Display(Name = "Does your supervisor have a travel grant?")]
        public bool supervisorGrant { get; set; }
        [Display(Name = "Do you have a VC Conference grant?")]
        public double VCConferenceGrant { get; set; }
        [Display(Name = "Requested funding for Airfare")]
        public double airFare { get; set; }
        [Display(Name = "Requested funding for Accomodation")]
        public double accomodation { get; set; }
        [Display(Name = "Requested funding for Conference Fees")]
        public double conferenceFees { get; set; }
        [Display(Name = "Requested funding for Meals")]
        public double meals { get; set; }
        [Display(Name = "Requested funding for local Fares")]
        public double localFares { get; set; }
        [Display(Name = "Requested funding for Car Mileage")]
        public double carMileage { get; set; }
        [Display(Name = "Requested funding for Other")]
        public double other { get; set; }
        [Display(Name = "Total requested Funding")]
        public double totalExpenses { get; set; }

    }
}