using CurrencyConverter.Transactions.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Interfaces
{
    interface IOperationServices
    {
        List<OperationHistoric> GetListOperationTransaction();

        void SaveOperationTransaction(OperationHistoric operationHistoric);

        ConvertedCurrency ConvertCoinOperation(string coinType);

        void CalcIofAndSpread(decimal valueOperation);

        ConvertedCurrency SaveConvertedCurrency(ConvertedCurrency convertedCurrency);

    }
}
