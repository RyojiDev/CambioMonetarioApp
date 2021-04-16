using CurrencyConverter.Transactions.API.Controllers;
using CurrencyConverter.Transactions.API.Interfaces;
using CurrencyConverter.Transactions.API.Model;
using CurrencyConverter.Transactions.API.Repository;
using CurrencyConverter.Transactions.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiCurrencyConverterXunitTests
{
    public class CurrencyTransactionTesteController
    {
        private IOperationServices _operationServices;

        public static DbContextOptions<CurrencyOperationDBContext> dbContextOptions { get; }

        public static string connectionString = "server=(LocalDB)\\MSSQLLocalDB;DataBase=CurrencyOperation;User Id=User;Password=1234";

        static CurrencyTransactionTesteController()
        {
            dbContextOptions = new DbContextOptionsBuilder<CurrencyOperationDBContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        public CurrencyTransactionTesteController()
        {
            var context = new CurrencyOperationDBContext(dbContextOptions);
            _operationServices = new OperationServices(context);
        }

        [Fact]
        public void GetOperations_Return_OkResult()
        {
            //Arrange
            var controller = new CurrencyTransactionController(_operationServices);

            //Act
            var data = controller.ListOperations();

            //Assert
            Assert.IsType<List<Operation>>(data.Value);
        }
    }
   
}
