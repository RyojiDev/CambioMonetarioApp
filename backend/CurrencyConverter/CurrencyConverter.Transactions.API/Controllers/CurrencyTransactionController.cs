using CurrencyConverter.Transactions.API.Interfaces;
using CurrencyConverter.Transactions.API.Model;
using CurrencyConverter.Transactions.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Controllers
{
    public class CurrencyTransactionController : ControllerBase
    {
        private IOperationServices _operationServices = new OperationServices();


        public IActionResult ListOperations()
        {
            List<OperationHistoric> operationHistorics = new List<OperationHistoric>();
            return Ok(operationHistorics);
        }

        public IActionResult ConvertValueOperation(string currencyCoin)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult SaveConvertedCurrency([FromBody] ConvertedCurrency currencyCoin)
        {
            ConvertedCurrency convertedCurrency = new ConvertedCurrency();
            convertedCurrency = _operationServices.SaveConvertedCurrency(convertedCurrency);

            return Ok(convertedCurrency);
        }
    }
}
