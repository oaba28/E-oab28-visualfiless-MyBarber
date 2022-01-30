using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBarber
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int appointID { get; set; }
        [Display(Name = "ID")]
        public String barberID { get; set; }
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