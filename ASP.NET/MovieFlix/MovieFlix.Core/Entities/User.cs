using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class User:IdentityUser
    {
        
        [Column(TypeName = "varchar(128)")]
        public string? FirstName { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string? LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        [Column(TypeName = "varchar(1024)")]
        public string? Salt { get; set; }
        
        public DateTime LastLoginDateTime { get; set; }
    }
}
