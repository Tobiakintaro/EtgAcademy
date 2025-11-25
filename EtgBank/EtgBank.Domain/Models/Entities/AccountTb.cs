using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Domain.Models.Entities
{
    public class AccountTb
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string Tier {  get; set; }
        public CustomerTb Customer { get; set; }

    public ICollection<TransactionTb> Transactions { get; set; }
    }
}
