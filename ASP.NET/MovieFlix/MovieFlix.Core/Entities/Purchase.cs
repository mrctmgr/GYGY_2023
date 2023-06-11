using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public Guid PurchaseNumber { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        [Required]
        [Column(TypeName = "datetime2(7)")]
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

    }
}
