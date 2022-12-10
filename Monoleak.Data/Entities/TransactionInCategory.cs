using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.Entities
{
    public class TransactionInCategory
    {
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
