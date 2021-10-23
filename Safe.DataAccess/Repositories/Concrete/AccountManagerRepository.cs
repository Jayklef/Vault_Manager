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
                Id = a.Id,
                Name = a.Name,
                StaffNumber = a.StaffNumber
            }).ToList();

            return accountManagers;
        }

        public AccountManagerDto GetAccountManagerById(int Id)
        {
            var accountManager = _context.AccountManagers.Where(a => a.Id == Id).Select(a => new AccountManagerDto
            {
                Id = a.Id,
                Name = a.Name,
                StaffNumber = a.StaffNumber
            }).FirstOrDefault();

            return accountManager;
        }
        public void CreateAccountManager(AccountManagerDto accountManagerDto)
        {
            var accountManager = new AccountManager
            {
                Name = accountManagerDto.Name,
                StaffNumber = accountManagerDto.StaffNumber
            };

            _context.Add(accountManager);
            _context.SaveChanges();
        }
    }
}
