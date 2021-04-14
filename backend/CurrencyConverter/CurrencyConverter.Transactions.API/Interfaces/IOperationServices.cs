using CurrencyConverter.Transactions.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Interfaces
{
    public interface IOperationServices
    {
        List<Operation> GetListOperationTransaction();

        void SaveOperationTransaction(ConvertedCurrency convertedCurrency);

        decimal CalcIofAndSpread(decimal subTotalValue, decimal iof, decimal spread, decimal baseValue);

        decimal ConvertCurrencyValue(decimal valueToConverted, decimal baseValue);

        ConvertedCurrency SaveConvertedCurrency(ConvertedCurrency convertedCurrency);

    }
}
