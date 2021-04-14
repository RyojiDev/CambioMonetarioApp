using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Model
{
    public class ConvertedCurrency
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
        public decimal BaseValue { get; set; } 
        
        [Required]
        public decimal ValueToconvert { get; set; }


        public decimal? TotalValueConverted { get; set; }

        [Required]
        public decimal IOF { get; set; }

        [Required]
        public decimal Spread { get; set; }
    }
}
