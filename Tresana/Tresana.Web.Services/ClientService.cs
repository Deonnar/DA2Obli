using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;
using Tresana.Data.Repository;

namespace Tresana.Web.Services
{
    public class ClientService
    {
        private readonly IUnitOfWork unitOfWork;

        public Client GetClientById(int clientId)
        {
            Client user = unitOfWork.ClientRepository.GetByID(clientId);
            return user;
        }
        public IEnumerable<Client> GetAllClients()
        {
            return unitOfWork.ClientRepository.Get(null, null, "");
        }
        public int CreateClient(Client client)
        {
            unitOfWork.ClientRepository.Insert(client);
            unitOfWork.Save();
            return client.ClientId;
        }

        public bool UpdateClient(int Id, Client client)
        {
            if (ExistsClient(Id))
            {
                Client clientEntity = unitOfWork.ClientRepository.GetByID(Id);
                clientEntity.Name= client.Name;
                clientEntity.Email = client.Email;
                clientEntity.Address = client.Address;

                unitOfWork.ClientRepository.Update(clientEntity);
                unitOfWork.Save();
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        private bool ExistsClient(int clientId)
        {
            Client user = unitOfWork.ClientRepository.GetByID(clientId);
            return user != null;
        }

    }
}
