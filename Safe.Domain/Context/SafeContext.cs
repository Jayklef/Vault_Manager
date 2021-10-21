using Microsoft.EntityFrameworkCore;
using Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Domain
{
    public class SafeContext : DbContext
    {
        public SafeContext(DbContextOptions<SafeContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<AccountManager> AccountManagers { get; set; }
    }
}
