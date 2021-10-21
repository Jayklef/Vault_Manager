using Safe.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Interface
{
    public interface IAccountManager
    {
        List<AccountManagerDto> GetAllAccountManagers();
        AccountManagerDto GetAccountManagerById(int id);
        void CreateAccountManager(AccountManagerDto accountManagerDto);
    }
}
