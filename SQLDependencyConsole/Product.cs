using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barmate.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal? TakeAwayPrice { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal? DeliveryPrice { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal? VatPercentage { get; set; }
        public int? Unit { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
