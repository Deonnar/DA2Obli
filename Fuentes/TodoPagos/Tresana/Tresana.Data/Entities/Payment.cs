using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresana.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public DateTime DueDate { get; set; }

        public Boolean IsPaid { get; set; }

        public DateTime EmisionDate { get; set; }

        public int Amount { get; set; }
    }
}
