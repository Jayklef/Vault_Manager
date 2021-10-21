using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Interface;
using Safe.Domain;
using Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Concrete
{
    public class AccountManagerRepository : IAccountManager
    {
        private readonly SafeContext _context;

        public AccountManagerRepository(SafeContext context)
        {
            _context = context;
        }

        public List<AccountManagerDto> GetAllAccountManagers()
        {
            var accountManagers = _context.AccountManagers.Select(a => new AccountManagerDto
            {
                id = a.id,
                name = a.name,
                staffNumber = a.staffNumber
            }).ToList();

            return accountManagers;
        }

        public AccountManagerDto GetAccountManagerById(int id)
        {
            var accountManager = _context.AccountManagers.Where(a => a.id == id).Select(a => new AccountManagerDto
            {
                id = a.id,
                name = a.name,
                staffNumber = a.staffNumber
            }).FirstOrDefault();

            return accountManager;
        }
        public void CreateAccountManager(AccountManagerDto accountManagerDto)
        {
            var accountManager = new AccountManager
            {
                name = accountManagerDto.name,
                staffNumber = accountManagerDto.staffNumber
            };

            _context.Add(accountManager);
            _context.SaveChanges();
        }
    }
}
