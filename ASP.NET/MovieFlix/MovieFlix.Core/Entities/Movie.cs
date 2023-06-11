using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieFlix.Core.Entities
{
    public class Movie
    { /*[Required] makes the property "Not Nullable"
       * "Id" will be automatically chosen to be PK
       */

        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(256)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? Overview { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string? Tagline { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Budget { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Revenue { get; set; }
        [Column(TypeName = "varchar(2084)")]
        public string? ImdbUrl { get; set; }
        [Column(TypeName = "varchar(2084)")]
        public string? TmdbUrl { get; set; }
        [Column(TypeName = "varchar(2084)")]
        public string? PosterUrl { get; set; }
        [Column(TypeName = "varchar(2084)")]
        public string? BackdropUrl { get; set; }
        [Column(TypeName = "varchar(64)")]
        public string? OriginalLanguage { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime? UpdatedDate { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string? CreatedBy { get; set; }

        public virtual ICollection<MovieGenre>? MovieGenres { get; set; }
        public virtual ICollection<MovieCrew>? MovieCrews { get; set; }
        public virtual ICollection<MovieCast>? MovieCasts { get; set; }
        public virtual ICollection<Favorite>? Favorites { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Purchase>? Purchases { get; set; }
        public virtual ICollection<Trailer>? Trailers { get; set; }


    }
}
