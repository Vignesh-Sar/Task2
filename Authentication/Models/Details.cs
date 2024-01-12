using System;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class Details
    {
        
        [Key]
        public string? StatusNo{get; set;}
        [Required]
        public string? Name{get; set;}
        [Required]
        public string? Domain{get; set;}
        public string? Status{get; set;}
        public string? City{get; set;}

    }
}