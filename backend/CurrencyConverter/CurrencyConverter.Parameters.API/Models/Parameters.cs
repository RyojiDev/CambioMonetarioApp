using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Parameters.API.Models
{
    public class Parameters
    {
        public List<Currency> Currencies { get; set; }
        public double Spread { get; set; }
        public double IOF { get; set; }
    }
}
