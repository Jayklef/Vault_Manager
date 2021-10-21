using Safe.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Interface
{
    public interface IClientRepository
    {
        List<ClientDto> GetAllClients();
        ClientDto GetClientById(int Id);
        void CreateClient(ClientDto clientDto);
        void UpdateClient(ClientDto clientDto);
        void DeleteClient(int Id);
    }
}
