using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Domain.Models.Entities
{
    public class CustomerTb
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password  { get; set; }
        public DateTime CreateDate  { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int TierId { get; set; }
        public TierTb Tier { get; set; }
        public ICollection<AccountTb> Accounts { get; set; }
    }
}
