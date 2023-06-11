using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [Required]
        [Column(TypeName = "decimal(3,2)")]
        public decimal Rating { get; set; }
        [Column(TypeName="varchar(MAX)")]
        public string? ReviewText { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
