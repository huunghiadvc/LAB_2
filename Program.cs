using System;
using Lab_2.const_;
using Lab_2.model;
using LAB_2a.controller;


namespace LAB_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person("Huu Nghia", "11/12/1998", "Ha Noi");
            Person user2 = new Person("Nghia", "11/12/1998", "Ha Noi");
            BankAccount bankAccount = new BankAccount(user, "123456", "account1", "admin@123", STATUS.ACTIVE, 1000000000);
            BankAccount bankAccount2 = new BankAccount(user2, "654321", "account2", "123", STATUS.ACTIVE, 0);
            Bank.GetAccounts().Add(bankAccount);
            Bank.GetAccounts().Add(bankAccount2);

            while (true)
            {
                AppController.Control();
            }
        }
    }
}
