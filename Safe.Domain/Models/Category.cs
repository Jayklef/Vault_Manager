
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
        public int id { get; set; }

        public string categoryName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal amountPerMonth { get; set; }
    }
}
