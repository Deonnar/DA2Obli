using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;
using Tresana.Data.Repository;

namespace Tresana.Web.Services
{
    public class ProviderFieldService: IProviderFieldService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProviderFieldService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<ProviderField> GetAllProviderFields()
        {
            return unitOfWork.ProviderFieldRepository.Get(null, null, "");
        }

        public int CreateProviderField(ProviderField providerField)
        {
            unitOfWork.ProviderFieldRepository.Insert(providerField);
            unitOfWork.Save();
            return providerField.ProviderFieldId;
        }

        public bool UpdateProviderField(int providerFieldId, ProviderField providerField)
        {
            if (ExistsProviderField(providerFieldId))
            {
                ProviderField providerFieldEntity = unitOfWork.ProviderFieldRepository.GetByID(providerFieldId);
                providerFieldEntity.Provider = providerField.Provider;
                providerFieldEntity.FieldName = providerField.FieldName;              
                unitOfWork.ProviderFieldRepository.Update(providerFieldEntity);
                unitOfWork.Save();
                return true;
            }
            return false;
        }
        public bool DeleteProviderField(int providerFieldId)
        {
            if (ExistsProviderField(providerFieldId))
            {
                unitOfWork.ProviderFieldRepository.Delete(providerFieldId);
                unitOfWork.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
 
        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        private bool ExistsProviderField(int providerFieldId)
        {
            ProviderField providerField = unitOfWork.ProviderFieldRepository.GetByID(providerFieldId);
            return providerField != null;
        }
    }
}
