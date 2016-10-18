using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresana.Data.Entities
{
    public class ProviderField
    {
        public int ProviderFieldId { get; set; }
        public Provider Provider { get; set; }
        public string FieldName { get; set; }
    }
}
