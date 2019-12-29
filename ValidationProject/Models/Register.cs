using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationProject.Models
{
    public class Register
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [UIHint("Date")]
        public DateTime Birthdate { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
