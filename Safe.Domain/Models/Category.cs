
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal AmountPerMonth { get; set; }

        public IEnumerable<Item> Items { get; set; }

    }
}
