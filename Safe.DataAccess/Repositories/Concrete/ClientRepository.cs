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
    public class ClientRepository : IClientRepository
    {
        private readonly SafeContext _context;

        public ClientRepository(SafeContext context)
        {
            _context = context;
        }

        public List<ClientDto> GetAllClients()
        {
            var clients = _context.Clients.Select(c => new ClientDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Address = c.Address,
                Gender = c.Gender,
                Profession = c.Profession,
                Birthdate = c.Birthdate,
                PhoneNumber = c.PhoneNumber
            }).ToList();

            return clients;
        }

        public ClientDto GetClientById(int Id)
        {
            var client = _context.Clients.Where(c => c.Id == Id).Select(c => new ClientDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Address = c.Address,
                Gender = c.Gender,
                Profession = c.Profession,
                Birthdate = c.Birthdate,
                PhoneNumber = c.PhoneNumber
            }).FirstOrDefault();

            return client;
        }

        public void CreateClient(ClientDto clientDto)
        {
            var client = new Client
            {
                RequestId = clientDto.RequestId,
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                Address = clientDto.Address,
                Gender = clientDto.Gender,
                Profession = clientDto.Profession,
                Birthdate = clientDto.Birthdate,
                PhoneNumber = clientDto.PhoneNumber
            };

            _context.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(ClientDto clientDto)
        {
            var client = _context.Clients.Where(c => c.Id == clientDto.Id).FirstOrDefault();

            client.FirstName = clientDto.FirstName;
            client.LastName = clientDto.LastName;
            client.Address = clientDto.Address;
            client.Gender = clientDto.Gender;
            client.Profession = clientDto.Profession;
            client.Birthdate = clientDto.Birthdate;
            client.PhoneNumber = clientDto.PhoneNumber;

            _context.SaveChanges();
        }

        public void DeleteClient(int Id)
        {
            var client = _context.Clients.Where(c => c.Id == Id).FirstOrDefault();

            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
