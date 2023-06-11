using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class Favorite
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
