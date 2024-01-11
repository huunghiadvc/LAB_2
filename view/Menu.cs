using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_2a.view
{
    public class Menu
    {
        public static void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("         HEY, THERE");
            Console.WriteLine("         1. Login");
            Console.WriteLine("         2. Exit");
            Console.WriteLine("         Please enter your choice :");
        }

        public static void ServiceMenu()
        {
            Console.WriteLine();
            Console.WriteLine("         WELCOME TO BANK");
            Console.WriteLine("         1. Check balance");
            Console.WriteLine("         2. Withdraw");
            Console.WriteLine("         3. Deposit");
            Console.WriteLine("         4. Exit");
            Console.WriteLine("         Please enter your choice :");
        }

        public static void WithDrawService()
        {
            Console.WriteLine();
            Console.WriteLine("         WITHDRAW SERVICES");
            Console.WriteLine("         1. 50.000");
            Console.WriteLine("         2. 500.000");
            Console.WriteLine("         3. 1.500.000");
            Console.WriteLine("         4. Different amount ");
            Console.WriteLine("         5. Back");
            Console.WriteLine("         Please enter your choice :");
        }
    }
}