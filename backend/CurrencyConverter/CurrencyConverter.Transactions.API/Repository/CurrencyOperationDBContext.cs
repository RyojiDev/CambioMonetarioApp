using CurrencyConverter.Transactions.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Repository
{
    public class CurrencyOperationDBContext : DbContext
    {
        public CurrencyOperationDBContext(DbContextOptions<CurrencyOperationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<ConvertedCurrency> Currency { get; set; }
    }
}
