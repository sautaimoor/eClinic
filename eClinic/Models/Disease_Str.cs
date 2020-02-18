using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eClinic.Models
{
    public class Disease_Str
    {
        public int Id { get; set; }
        public System.Guid GUID { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Disease Type")]
        public string Type { get; set; }
        public string Description { get; set; }
        public bool?IsActive { get; set; }
        public int? Cost { get; set; }
    }
}