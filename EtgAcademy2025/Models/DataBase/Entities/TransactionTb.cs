using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025.Models.DataBase.Entities
{

    // [Table("tranlog")]

    [Index(nameof(TransactionId), IsUnique = true)]
    [Index(nameof(TransactionDate), nameof(TransactionId))]
    public class TransactionTb
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public required string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(10)]
        public required string AccountId { get; set; }
    }
}
