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
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal CurrentValue { get; set; }
        public Category Category { get; set; }
        public Client Client { get; set; }
    }
}
