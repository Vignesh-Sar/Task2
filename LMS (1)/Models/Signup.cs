using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models{
    public class Signup{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        [StringLength(20,MinimumLength = 3)]
        // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9]))*$",ErrorMessage ="Username Mustbe contains atleast 3 charaters and it's Mustbe include Charaters and numbers shouldn't contains special any charater's")]
        public string? UserName{get; set;}
        [Required]
        [StringLength(20,MinimumLength = 3)]
        // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9])(?=.*?[@!#$%^&*]))*$",ErrorMessage ="Password Mustbe contains atleast 3 charaters and it's Mustbe include Charaters,numbers and Special character's")]
      
        public string? PassWord {get; set;}
        [Required]
        [StringLength(8,MinimumLength = 7)]
        // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9]))*$",ErrorMessage ="Userid atleat contains 8 or 7 character's include Characters and Numbers")]
      
        public string ? UserID {get;set;}

        
       
    
       
    }
    
}