using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Model
{
    public class OperationHistoric
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string FromCoin { get; set; }

        [Required]
        [StringLength(15)]
        public string ToCoin { get; set; }

        [Required]
        public decimal OperationValue { get; set; }

        [Required]
        public DateTime OperationDate { get; set; }
    }
}
