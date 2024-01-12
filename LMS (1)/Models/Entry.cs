using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Entry
    {
        [Key]
        
        public int userid {get;set;}
        public string ? username {get;set;}
        
        public int  password {get;set;}
    }
    public class Jwt{
        public string ? key {get;set;}
        public string ? Issuer {get;set;}
        public string ? Audience {get ; set;}
        public string ? Subject {get ; set;}
    }
}