using MovieFlix.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Models
{
    public class MovieCastModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [Required]
        public int CastId { get; set; }
        [Required]
        public string Character { get; set; }

        public virtual CastModel? Cast { get; set; }
    }
}
