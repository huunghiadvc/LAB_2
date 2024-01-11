using System;
using Lab_2.const_;

namespace Lab_2.model
{
    public class BankAccount
    {
        private static long currentID = 0;
        private long id;
        private Person person;
        private string accountNumber;
        private string username;
        private string password;
        private STATUS status;
        private decimal balance;

        public BankAccount(Person user, string AccountNumber, string username, string password, STATUS status, decimal balance)
        {
            this.id = ++currentID;
            this.person = user;
            this.accountNumber = AccountNumber;
            this.username = username;
            this.password = password;
            this.status = status;
            this.balance = balance;
        }

        public long Id
        {
            get { return this.id; }
        }

        public Person Person
        {
            get { return this.person; }
            set { this.person = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }


        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public STATUS Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public bool Withdraw(long amount)
        {
            decimal fee = Convert.ToDecimal(amount) * Bank.WITHDRAW_FEE / 100;
            decimal sum = amount + fee;
            if (Bank.MIN_BALANCE <= (this.Balance - sum))
            {
                this.Balance -= sum;
                return true;
            }
            return false;
        }

        public bool SaveMoney(long amount)
        {
            this.Balance += amount;
            Console.WriteLine("Save Money successfully!");
            return true;
        }

        public override string ToString()
        {
            return $"Account Information: Username - {this.username}, Balance - {this.balance}";
        }
    }

}