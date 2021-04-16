using CurrencyConverter.Transactions.API.Model;
using CurrencyConverter.Transactions.API.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCurrencyConverterXunitTests
{
    public class DDUnitTestsMockInitializer
    {
        public DDUnitTestsMockInitializer(CurrencyOperationDBContext context)
        {
            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 5.50M,
                  ToCoin = "USD",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );

            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 5.50M,
                  ToCoin = "USD",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );

            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 5.50M,
                  ToCoin = "USD",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );

            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 5.50M,
                  ToCoin = "USD",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );


            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 6.72M,
                  ToCoin = "EUR",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );


            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 7.74M,
                  ToCoin = "LBR",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );


            context.Add(
              new ConvertedCurrency
              {
                  FromCoin = "BRL",
                  IOF = 1.1M,
                  BaseValue = 5.50M,
                  ToCoin = "USD",
                  Spread = 1.2M,
                  ValueToconvert = 2.500M,
              }
                );
        }
    }
}
