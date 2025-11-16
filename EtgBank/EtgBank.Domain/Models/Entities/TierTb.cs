using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Domain.Models.Entities
{
    public class TierTb
    {
        public int Id { get; set; }.
        public string Tier {  get; set; }
        public decimal DailyLimit { get; set; }
        public decimal SingleLimit { get; set; }
        public decimal MaxBalance { get; set; }
    }
}
