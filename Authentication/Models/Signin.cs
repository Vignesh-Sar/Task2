using System.ComponentModel.DataAnnotations;

namespace Authentication
{
    public class Signin
    {
        [Key]
        public string ? Username {get; set;}
        [Required]
        public string ? Password {get; set;}
    }
}