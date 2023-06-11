using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(256, ErrorMessage ="Maximium 256 characters are allowed")]
        public string Title { get; set; }
        public string? Overview { get; set; }
        [MaxLength(512, ErrorMessage = "Maximium 512 characters are allowed")]
        public string? Tagline { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        [MaxLength(2084, ErrorMessage = "Maximium 2084 characters are allowed")]
        public string? ImdbUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "Maximium 2084 characters are allowed")]
        public string? TmdbUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "Maximium 2084 characters are allowed")]
        public string? PosterUrl { get; set; }
        [MaxLength(2084, ErrorMessage = "Maximium 2084 characters are allowed")]
        public string? BackdropUrl { get; set; }
        [MaxLength(64, ErrorMessage = "Maximium 64 characters are allowed")]
        public string? OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CreatedBy { get; set; }

        public virtual IEnumerable<MovieCastModel>? MovieCasts { get; set; }
    }
}
