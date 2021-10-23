using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Domain.Models
{
    public class AccountManager
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StaffNumber { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
