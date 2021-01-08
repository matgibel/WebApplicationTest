using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        
        [EmailAddress]
        public EmailAddressAttribute Email { get; set; }
        
        
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password")]
        public string ConfirmPassword { get; set; }

        
        public DateTime CreationTime { get; set; }
        
        public DateTime LogginTime { get; set; }
    }
}
