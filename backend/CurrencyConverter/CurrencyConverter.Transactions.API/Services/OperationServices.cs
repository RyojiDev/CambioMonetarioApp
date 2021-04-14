using CurrencyConverter.Transactions.API.Interfaces;
using CurrencyConverter.Transactions.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Services
{
    public class OperationServices : IOperationServices
    {
        public void CalcIofAndSpread(decimal valueOperation)
        {
            throw new NotImplementedException();
        }

        public ConvertedCurrency ConvertCoinOperation(string coinType)
        {
            throw new NotImplementedException();
        }

        public List<OperationHistoric> GetListOperationTransaction()
        {
            throw new NotImplementedException();
        }

        public ConvertedCurrency SaveOperationTransaction(OperationHistoric operationHistoric)
        {
            throw new NotImplementedException();
        }
    }
}
