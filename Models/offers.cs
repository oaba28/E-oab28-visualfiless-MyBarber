using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBarber
{
    public class offers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int activity_id { get; set; }
        [Display(Name = "ADMIN")]
        public String admin_name { get; set; }
        [Display(Name = "UPDATED DATE")]
        public DateTime update_date { get; set; }
        [Display(Name = "CATEGORY")]
        public string category_name { get; set; }
        public string sub_category_name { get; set; }
        [Display(Name = "PROCESS")]
        public string process_name { get; set; }
        [Display(Name = "FILE NAME")]
        public string file_name { get; set; }
        [Display(Name = "FILE NUMBER")]
        public int file_number { get; set; }

    }
}