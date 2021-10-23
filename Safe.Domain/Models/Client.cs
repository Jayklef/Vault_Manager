using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Domain.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public AccountManager AccountManager { get; set; }
    }
}
