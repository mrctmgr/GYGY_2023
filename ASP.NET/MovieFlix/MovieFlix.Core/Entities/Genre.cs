using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieFlix.Core.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(64)")]
        public string Name { get; set; }

        public virtual ICollection<MovieGenre>? MovieGenres { get; set; }

       
    }
}
