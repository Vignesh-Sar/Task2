using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models{
    public class ForgetPassWord{
    [Key]
    [Required]
    [StringLength(20,MinimumLength = 3)]
    // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9]))$",ErrorMessage ="Username Mustbe contains atleast 3 charaters and it's Mustbe include Charaters and numbers shouldn't contains special any charater's")]
      
    public string? Name{get;set;}
    [Required]
    [StringLength(20,MinimumLength = 3)]
    // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9])(?=.*?[@!#$%^&*]))$",ErrorMessage ="Password Mustbe contains atleast 3 charaters and it's Mustbe include Charaters,numbers and Special character's")]
    public string? PassWord2{get;set;}
    }

}