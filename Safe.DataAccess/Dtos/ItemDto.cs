using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Dtos
{
    public class ItemDto
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public decimal currentValue { get; set; }
    }
}
