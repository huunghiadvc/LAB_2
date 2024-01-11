using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2.model
{
    public class Bank
    {
        public const decimal MIN_BALANCE = 50000;
        public const decimal WITHDRAW_FEE = 0.67m;
        public const decimal FEE = 0;
        private static List<BankAccount>? accounts;
        private Bank() { }
        public static List<BankAccount> GetAccounts()
        {
            if (accounts == null)
            {
                accounts = new List<BankAccount>();
            }
            return accounts;
        }
    }
}