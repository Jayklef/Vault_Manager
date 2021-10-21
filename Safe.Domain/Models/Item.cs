using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Domain.Models
{
    public class Item
    {
        [Key]
        public int itemId { get; set; }

        public string itemName { get; set; }

        public string itemDescription { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal currentValue { get; set; }
    }
}
