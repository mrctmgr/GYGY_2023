using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class MovieCrew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Department { get; set; }
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string job { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Crew Crew { get; set; }
    }
}
