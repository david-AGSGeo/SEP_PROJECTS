using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class TravelApplication
    {
        
        public int TravelApplicationID { get; set; }

        [Display(Name = "Are you a staff member?")]
        public bool isStaffMember { get; set; }

        [Display(Name = "Is this your first Application this year?")]
        public bool firstApplicationThisYear { get; set; }

        [Display(Name = "What is the submission Date?")]
        public DateTime submitDate { get; set; }
        [Display(Name = "Has your supervisor approved your request?")]
        public bool supervisorApproved { get; set; }
        
        
        [Display(Name = "Total Ammount Approved")]
        public int totalApproved { get; set; }
        [Display(Name = "Date Approved")]
        public DateTime dateApproved { get; set; }

        //[Display(Name = "Travel Details")]
        public TravelDetails travelDetails {get; set;}
        //[Display(Name = "Funding Details")]
        public FundingDetails fundingDetails {get; set;}
        
    }
}