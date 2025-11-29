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
        public int TierId { get; set; }      
        public DateTime CreateDate { get; set; }
    }
}
