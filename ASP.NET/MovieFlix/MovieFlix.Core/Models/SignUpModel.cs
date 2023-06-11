using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Models
{
    public class SignUpModel
    {
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        public string? Email { get; set; }
        [Compare("ConfirmPassword")]
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        

    }
}
