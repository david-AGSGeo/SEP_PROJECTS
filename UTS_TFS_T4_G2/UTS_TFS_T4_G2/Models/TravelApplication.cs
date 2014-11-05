using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class TravelApplication
    {
        
        public int TravelApplicationID { get; set; }

        public ApplicationUser User;
        public bool isStaffMember { get; set; }
        public bool firstApplicationThisYear { get; set; }
        public DateTime submitDate { get; set; }
        public bool supervisorApproved { get; set; }
        public int totalApproved { get; set; }
        public DateTime dateApproved { get; set; }
        
        public TravelDetails travelDetails {get; set;}
        public FundingDetails fundingDetails {get; set;}
        
    }
}