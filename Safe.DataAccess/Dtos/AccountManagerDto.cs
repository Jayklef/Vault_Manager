using Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Dtos
{
    public class AccountManagerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StaffNumber { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
