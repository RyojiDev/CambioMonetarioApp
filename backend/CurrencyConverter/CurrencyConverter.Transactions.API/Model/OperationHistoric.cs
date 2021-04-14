using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Model
{
    public class OperationHistoric
    {
        public int Id { get; set; }
        public string FromCoin { get; set; }
        public string ToCoin { get; set; }
        public decimal OperationValue { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
