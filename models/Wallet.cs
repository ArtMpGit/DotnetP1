using System;
using System.Collections.Generic;

namespace P1.NET.models
{
    public class Wallet
    {
        private List<Stock> stocks;
        public List<Stock> Stocks
        {
            get => stocks;
        }

        public Wallet()
        {
            stocks = new List<Stock>();
        }
        public void registerStock(Stock stock)
        {
            int stockIndex = stocks.FindIndex(s => s.Code.ToLower().Equals(stock.Code.ToLower()));
            if (stockIndex >= 0)
            {
                stocks[stockIndex].Quantity += stock.Quantity;
                Console.WriteLine("The stock was successfully incremented.");
            }
            else
            {
                stocks.Add(stock);
                Console.WriteLine("The stock was successfully registered.");
            };
        }
        public Stock searchStock(string code) =>
             stocks.Find(s => s.Code.ToLower().Equals(code.ToLower()));
    }

}