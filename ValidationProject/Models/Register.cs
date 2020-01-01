using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationProject.Models
{
    public class Register
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(6,ErrorMessage ="Password's count must be greater than 6")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Please write password again")]
        public string RePassword { get; set; }
        [UIHint("Date")]
        public DateTime Birthdate { get; set; }
        [Range(typeof(bool),"true","true",ErrorMessage ="Please,accept our all terms .")]
        public bool TermsAccepted { get; set; }
    }
}
