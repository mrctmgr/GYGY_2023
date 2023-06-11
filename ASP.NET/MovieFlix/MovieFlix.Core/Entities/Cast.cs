using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class Cast
    {
        public int Id { get; set; }
        [Column(TypeName="varchar(128)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? Gender { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? TmdbUrl { get; set; }
        [Column(TypeName = "varchar(2048)")]
        public string? ProfilePath { get; set; }

        //public MovieCast? MovieCast { get; set; }

        public virtual ICollection<MovieCast>? MovieCasts { get; set; }
    }
}
