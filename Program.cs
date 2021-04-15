using System;
using System.Collections.Generic;
using P1.NET.models;

namespace P1.NET
{
    class Program
    {

        private static Wallet wallet;
        private static string userOption;
        private static Boolean stopOperation;

        static void Main(string[] args)
        {
            wallet = new Wallet();
            Console.WriteLine("Welcome to the U.N.I.O.N Stock market menu!\nplease, select one of the options bellow to continue\nor type anything else if you want to leave the menu");
            do
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                showMenu();
                userOption = Console.ReadLine();
                switch (userOption)
                {
                    case "1":
                        registerStock();
                        break;
                    case "2":
                        searchStock();
                        break;
                    case "3":
                        visualizeRegisteredStocks();
                        break;
                    default:
                        exitMenu();
                        break;
                }

            } while (!stopOperation);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("The operation was ended.");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        private static void showMenu()
        {
            Console.WriteLine("1 - Register a new stock");
            Console.WriteLine("2 - Search for an existing stock");
            Console.WriteLine("3 - Visualize all the registered stocks");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        private static void visualizeRegisteredStocks()
        {
            if (wallet.Stocks.Count > 0)
            {
                wallet.Stocks.ForEach(s =>
                {
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine("Code: " + s.Code);
                    Console.WriteLine("Quantity: " + s.Quantity);
                });
            }
            else Console.WriteLine("There are no stocks registered yet.");
        }

        private static void registerStock()
        {
            Console.Write("Choose a new code for the stock: ");
            string stockCode = Console.ReadLine();

            Console.Write("Now enter how many of those you want to register: ");
            int stockQuantity = Convert.ToInt32(Console.ReadLine());

            wallet.registerStock(new Stock(stockCode, stockQuantity));
        }

        private static void searchStock()
        {
            Console.Write("Please, inform us the stock code you are looking for: ");
            string searchedStockCode = Console.ReadLine();
            Stock searchedStock = wallet.searchStock(searchedStockCode);
            if (searchedStock == null)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("The inserted code does not correspond to any of the registered stocks.");
            }
            else
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("Stock information:\nCode: " + searchedStock.Code + "\nQuantity: " + searchedStock.Quantity);
            }
        }

        private static void exitMenu()
        {
            string userChoice;
            do
            {
                Console.Write("Do you want to end the operation? (y/n): ");
                userChoice = Console.ReadLine();
                if (userChoice.Equals("y") || userChoice.Equals("n"))
                {
                    stopOperation = userChoice.Equals("y");
                }

            } while (!userChoice.Equals("y") && !userChoice.Equals("n"));

        }

    }
}
