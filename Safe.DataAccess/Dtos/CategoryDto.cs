using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Dtos
{
    public class CategoryDto
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public decimal amountPerMonth { get; set; }
    }
}
