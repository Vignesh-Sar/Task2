using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
 
 
namespace Authentication
{
    public class data
    {
        
        [Key]
        public string? Id{get; set;}
        [Required(ErrorMessage ="Name is required")]
        // [RegularExpression(@"^[A-Za-z\s]+$",ErrorMessage ="Name cannot contain any numbers")]
        [RegularExpression(@"^(?!.*([A-Za-z])\1)[A-Za-z\s]+$",ErrorMessage ="Name should not contain repeated letters and  numbers")]

        public string? Name{get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Emailid{get; set;}
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? Phoneno{get; set;}
        [Required]
        [DataType(DataType.Date)]
        public string? Date{get; set;}
        [ScaffoldColumn(false)]
        [MaxLength(50)]
        public string? Address{get; set;}
        [Required]
        [Range(1,5 ,
        ErrorMessage ="give ratings from 1 to 5")]
        public int Ratings{get; set;}

    }
}