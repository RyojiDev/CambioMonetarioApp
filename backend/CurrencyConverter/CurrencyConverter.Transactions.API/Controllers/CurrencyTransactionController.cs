using CurrencyConverter.Transactions.API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Controllers
{
    public class CurrencyTransactionController : ControllerBase
    {
        public IActionResult ListOperations()
        {
            List<OperationHistoric> operationHistorics = new List<OperationHistoric>();
            return Ok(operationHistorics);
        }

        public IActionResult ConvertValueOperation()
        {
            return Ok();
        }
    }
}
