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
    [ApiController]
    [Route("[controller]")]
    public class CurrencyTransactionController : ControllerBase
    {
        private IOperationServices _operationServices;

        public CurrencyTransactionController(IOperationServices operationServices)
        {
            this._operationServices = operationServices;
        }

        List<Operation> operations = new List<Operation>();

        [HttpGet("ListOperations")]
        public IActionResult ListOperations()
        {
            
           operations = _operationServices.GetListOperationTransaction();
             if (operations == null)
                return NotFound();
           
            return Ok(operations);
        }

        [HttpPost("SaveConverted")]
        public IActionResult SaveConvertedCurrency([FromBody]ConvertedCurrency convertedCurrency)
        {
                 
            convertedCurrency = _operationServices.SaveConvertedCurrency(convertedCurrency);

            if (convertedCurrency == null)
                return NotFound();
            
            return Ok(convertedCurrency);
        }
    }
}
