using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;

namespace Tresana.Web.Services.Interfaces
{
    public interface IProviderService
    {
        Provider GetProviderById(int userId);
        IEnumerable<Provider> GetAllProviders();
        int CreateProvider(Provider provider);
        bool UpdateProvider(int Id, Provider provider);
        bool DeleteProvider(int Id);
    }
}
