using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Register
    {
        [Key]
        public string ? Userid{get;set;}
        [Required]
        [StringLength(20,MinimumLength = 3)]
        [RegularExpression(@"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@!#$%^&*]))$",ErrorMessage =" Not Valid")]
        public string ? Username{get;set;}
        [Required]
        [RegularExpression(@"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@])(?=.*?[gmail.com])$",ErrorMessage ="Email Not Valid")]
        public string ? Email{get;set;}
        [Required]
        [StringLength(10,MinimumLength = 10)]
        [RegularExpression(@"^(?=.*?[6-9])(?=.*?[0-9]))$",ErrorMessage =" Not Valid")]
        public string ? Phone{get;set;}
        [Required]
        public string ? Address{get;set;}


    }
}