using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;
using Tresana.Data.Repository;
using Tresana.Web.Services.Interfaces;

namespace Tresana.Web.Services.Implementations
{
    public class ProviderService: Interfaces.IProviderService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProviderService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Provider GetProviderById(int userId)
        {
            Provider user = unitOfWork.ProviderRepository.GetByID(userId);
            return user;
        }
        
        public IEnumerable<Provider> GetAllProviders()
        {
            return unitOfWork.ProviderRepository.Get(null, null, "");
        }
        public int CreateProvider(Provider provider)
        {
            unitOfWork.ProviderRepository.Insert(provider);
            unitOfWork.Save();
            return provider.ProviderId;
        }

        public bool UpdateProvider(int Id, Provider provider)
        {
            if (ExistsProvider(Id))
            {
                Provider providerEntity = unitOfWork.ProviderRepository.GetByID(Id);
                providerEntity.Name = provider.Name;
                providerEntity.RUT = provider.RUT;              
                unitOfWork.ProviderRepository.Update(providerEntity);
                unitOfWork.Save();
                return true;
            }
            return false;
        }
        public bool DeleteProvider(int Id)
        {
            if (ExistsProvider(Id))
            {
                unitOfWork.ProviderRepository.Delete(Id);
                unitOfWork.Save();
                return true;
            }
            return false;
        }


        private bool ExistsProvider(int Id)
        {
            Provider provider = unitOfWork.ProviderRepository.GetByID(Id);
            return provider != null;
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}


//public UserService()
//{
//    unitOfWork = new UnitOfWork();
//}



