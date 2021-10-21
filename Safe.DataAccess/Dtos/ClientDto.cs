using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
    }
}
