using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2.model;
using Lab_2.service;
using LAB_2a.view;

namespace LAB_2a.controller
{
    public class SubController
    {
        static BankService accountService = new BankService();
        public static BankAccount? account;
        static string? input;
        public static bool LoginController()
        {
            Menu.Welcome();
            input = Console.ReadLine();
            if (input.Equals("1"))
            {
                int num = 5;
                while (num > 0)
                {
                    Console.WriteLine("Enter account :");
                    string username = Console.ReadLine();
                    account = accountService.GetByUserName(username);
                    if (account == null)
                    {
                        Console.WriteLine("Invalid account!");
                        continue;
                    }
                    Console.WriteLine("Enter password :");
                    string password = Console.ReadLine();
                    if (password.Equals(account.Password))
                    {
                        return true;
                    }
                    num--;
                    Console.WriteLine("Invalid password ! {0} remaining", num);
                    if (num == 0)
                    {
                        accountService.BlockAccount(account.AccountNumber);
                    }
                }
            }
            if (input.Equals("0"))
            {
                Environment.Exit(0);
            }
            return false;
        }

        public static void ServiceController(string? input)
        {

            switch (input)
            {
                case "1":
                    Console.WriteLine("--- YOUR BALANCE : " + account.Balance + " ---");
                    break;

                case "2":
                    while (true)
                    {
                        Menu.WithDrawService();
                        long amount;
                        try
                        {
                            Console.WriteLine("Enter your choice :");
                            input = Console.ReadLine();
                            switch (input)
                            {
                                case "1":
                                    amount = 50000;
                                    break;
                                case "2":
                                    amount = 500000;
                                    break;
                                case "3":
                                    amount = 1500000;
                                    break;
                                case "4":
                                    Console.WriteLine("Enter amount :");
                                    input = Console.ReadLine();
                                    amount = long.Parse(input);
                                    if (amount % 50000 != 0)
                                    {
                                        Console.WriteLine("The amount needs to be a multiple of 50000!");
                                        continue;
                                    }
                                    break;
                                case "5":
                                    return;
                                default:
                                    Console.WriteLine("Please select 1-5");
                                    continue;
                            }
                            if (account.Withdraw(amount))
                            {
                                Console.WriteLine("Withdraw successfully!");
                                break;
                            }
                            Console.WriteLine("Withdraw failed!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("ERROR TO GET AMOUNT " + input);

                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter the amount to deposit :");
                    while (true)
                    {
                        input = Console.ReadLine();
                        long money;
                        try
                        {
                            money = long.Parse(input);
                            account.SaveMoney(money);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            Console.WriteLine("Try again :");
                        }
                    }
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}