using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models = CurrencyConverter.Parameters.API.Models;

namespace CurrencyConverter.Parameters.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParametersController : ControllerBase
    {
        private Models.Parameters _parameters;
        private readonly IConfiguration _config;

        public ParametersController(IConfiguration config)
        {

            _config = config;
            _parameters = _config.GetSection("Parameters").Get<Models.Parameters>();

        }
        [HttpGet]
        public Models.Parameters Get()
        {
            return _parameters;
        }
    }
}