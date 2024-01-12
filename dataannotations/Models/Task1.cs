using System;
using System.ComponentModel.DataAnnotations;

namespace dataannotations.Models
{
    public class Task1
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