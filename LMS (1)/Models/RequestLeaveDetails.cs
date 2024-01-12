using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class RequestLeaveDetails
    {
        [Key]
        [Required]
        [StringLength(8,MinimumLength = 7)]
        // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9])=)$",ErrorMessage ="Userid atleat contains 8 or 7 character's include Characters and Numbers")]
        public string? UserID{get;set;}
        [Required]
        [StringLength(20,MinimumLength = 3)]
        // [RegularExpression(@"^(?=.*?[a-zA-Z])(?=.*?[0-9]))$",ErrorMessage ="Username Mustbe contains atleast 3 charaters and it's Mustbe include Charaters and numbers shouldn't contains special any charater's")]
        public string? UserName{get;set;}
        public string? StartDate{get;set;}
        public string? EndDate{get;set;}
        public string? LeaveType{get;set;}
        public string? Email{get;set;}
        public string? EmRequest{get;set;}
        public string? ManRequest{get;set;}
        public string? Description{get;set;}
        public string? Type{get;set;}
        public int Privileged_Leave{get;set;}
        public int Compansatory_Leave{get;set;}
        public int Maternity_Leave{get;set;}
        public int Paternity_Leave{get;set;}
        public int LOP_Leave{get;set;}
        public int Carry_Forward{get;set;}
        public int Encashed_Days{get;set;}
        public int Marriage_Leave{get;set;}
        public int MTP_Leave{get;set;}

        public string? DateTime{get;set;}        
         


    }
}