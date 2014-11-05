using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UTS_TFS_T4_G2.Models
{
    public class JournalDetails
    {
        //public int JournalDetailsID { get; set; }
        [Display(Name = "Journal Name")]
        public string journalName { get; set; }
        [Display(Name = "Paper Description")]
        public string paperDescription { get; set; }
    }
}