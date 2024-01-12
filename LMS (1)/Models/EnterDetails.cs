using System;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace LMS.Models{
    public class EnterDetails
    {
        [Key]
        public string ID{get;set;}
        
        [Required]
        public string Name{get;set;}
        public string SDate{get;set;}
        public string? EDate{get;set;}
        public string? LT{get;set;}
    }


}