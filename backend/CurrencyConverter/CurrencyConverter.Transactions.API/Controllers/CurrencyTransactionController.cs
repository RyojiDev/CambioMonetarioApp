using CurrencyConverter.Transactions.API.Interfaces;
using CurrencyConverter.Transactions.API.Model;
using CurrencyConverter.Transactions.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Controllers
{
    public class CurrencyTransactionController : ControllerBase
    {
        private IOperationServices _operationServices = new OperationServices();

        List<Operation> operations = new List<Operation>();

        public IActionResult ListOperations()
        {
            try
            {
                operations = _operationServices.GetListOperationTransaction();
                if (operations != null)
                    return Ok(operations);
            }catch(Exception ex)
            {
                return NotFound(new { Error = ex.Message, Status = HttpStatusCode.NotFound });
            }

            return Ok(operations);
        }

        [HttpPost]
        public IActionResult SaveConvertedCurrency([FromBody]ConvertedCurrency convertedCurrency)
        {
           
            try { 
            convertedCurrency = _operationServices.SaveConvertedCurrency(convertedCurrency);

            if(convertedCurrency != null)

                return Ok(convertedCurrency);

            }catch(Exception ex) {

                return NotFound(new { Error = ex.Message, Status = HttpStatusCode.NotFound });
            }
            return Ok(convertedCurrency);
        }
    }
}
