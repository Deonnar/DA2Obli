using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;

namespace Tresana.Web.Services
{
    interface IProviderFieldService
    {
        //ProviderField GetPtById(int taskId);
        IEnumerable<ProviderField> GetAllProviderFields();
        int CreateProviderField(ProviderField providerField);
        bool UpdateProviderField(int providerFieldId, ProviderField providerField);
        bool DeleteProviderField(int providerFieldId);
    }
}
