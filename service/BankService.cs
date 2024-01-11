using System;
using System.Collections;
using Lab_2.model;

namespace Lab_2.service
{
    public class BankService
    {
        static List<BankAccount> accountList = Bank.GetAccounts();
        public BankAccount? GetByUserName(string username)
        {
            foreach (BankAccount account in accountList)
            {
                if (account.Username.Equals(username))
                {
                    return account;
                }
            }
            return null;
        }

        public void BlockAccount(string accountNumber)
        {
            foreach (BankAccount acc in accountList)
            {
                if (acc.AccountNumber.Equals(accountNumber))
                {
                    acc.Status = const_.STATUS.BLOCKED;
                }
            }
        }
    }
}