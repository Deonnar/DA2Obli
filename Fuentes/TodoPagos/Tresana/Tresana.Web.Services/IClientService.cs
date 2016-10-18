using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;

namespace Tresana.Web.Services
{
    public interface IClientService: IDisposable
    {
        Client GetClientById(int clientId);
        IEnumerable<Client> GetAllClients();
        int CreateClient(Client client);
        bool UpdateClient(int Id, Client client);
        bool DeleteClient(int clientId);
    }
}
