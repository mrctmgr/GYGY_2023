using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class Trailer
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [Column(TypeName="varchar(2084)")]
        public int TrailerId { get; set; }
        [Column(TypeName = "varchar(2084)")]
        public string? Name { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
