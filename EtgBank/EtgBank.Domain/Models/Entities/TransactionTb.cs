using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Domain.Models.Entities
{
    public class TransactionTb
    {
      public int Id { get; set; }
      public string TransactionId { get; set; }
      public string TraceId { get; set; }
      public string AccountNumber { get; set; }
      public decimal Amount { get; set; }
      public string Narration { get; set; }
      public DateTime EntryDate { get; set; } = DateTime.UtcNow;
      public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
      public int ResponseCode { get; set; }
      public string ResponseMessage { get; set; }
      public string TranType { get; set; }
      public string SessionId { get; set; }

    }
   
    }
