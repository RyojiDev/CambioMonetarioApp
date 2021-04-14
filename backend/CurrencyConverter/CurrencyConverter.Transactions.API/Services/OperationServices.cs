using CurrencyConverter.Transactions.API.Interfaces;
using CurrencyConverter.Transactions.API.Model;
using CurrencyConverter.Transactions.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Transactions.API.Services
{
    public class OperationServices : IOperationServices
    {
        private readonly CurrencyOperationDBContext _context;

        public OperationServices(CurrencyOperationDBContext context)
        {
            _context = context;
        }

        public decimal CalcIofAndSpread(decimal subTotalValue, decimal iof, decimal spread, decimal baseValue)
        {
            decimal iofValue = (subTotalValue / 100) * iof;
            decimal spreadValue = ((baseValue / 100) * spread) * subTotalValue;
            decimal totalValueForPay = iofValue + spreadValue + subTotalValue;

            return totalValueForPay;          
        }

        public decimal ConvertCurrencyValue(decimal valueToConverted, decimal baseValue)
        {
            return baseValue * valueToConverted;
        }

        public List<Operation> GetListOperationTransaction()
        {
            try { 

                Operation operation = new Operation();
                List<Operation> operationsHistoric = _context.Operations.ToList();

                return operationsHistoric;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConvertedCurrency SaveConvertedCurrency(ConvertedCurrency convertedCurrency)
        {
            try { 

                decimal valueSubtotal = ConvertCurrencyValue(convertedCurrency.ValueToconvert, convertedCurrency.BaseValue);
                decimal getTotalValueBeforeCalcIofAndSpread = CalcIofAndSpread(valueSubtotal, convertedCurrency.IOF, convertedCurrency.Spread, convertedCurrency.BaseValue);

                convertedCurrency.TotalValueConverted = getTotalValueBeforeCalcIofAndSpread;

                SaveOperationTransaction(convertedCurrency);

                var saveConvertedCurrency = _context.Add(convertedCurrency).Entity;
                _context.SaveChanges();

                return saveConvertedCurrency;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveOperationTransaction(ConvertedCurrency convertedCurrency)
        {
            try
            {
                Operation operation = new Operation()
                {
                    FromCoin = convertedCurrency.FromCoin,
                    ToCoin = convertedCurrency.ToCoin,
                    IOF = convertedCurrency.IOF,
                    OperationDate = DateTime.Now,
                    OperationValue = convertedCurrency.TotalValueConverted.Value,
                    Spread = convertedCurrency.Spread
                };

                var saveOperation = _context.Add(operation);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
