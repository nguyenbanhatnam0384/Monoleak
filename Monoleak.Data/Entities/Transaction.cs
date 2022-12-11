using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public List<TransactionInCategory> TransactionInCategories { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
