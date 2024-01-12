using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dataannotations.Models
{
    public class SignUp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? Id{get; set;}
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$",ErrorMessage ="Name should not contain any numbers")]
        public string Name{get; set;}
         [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage ="Password should contain atleast 8 characters,one capital letter, one small letter, one special character(#?!@$%^&*-),one number ")]
        public string Password{get; set;}
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$",ErrorMessage ="Role should not contain any numbers")]
        public string Role{get; set;}
    }
}