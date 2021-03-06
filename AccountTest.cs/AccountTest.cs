﻿using System;

class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("John Blue", -7.53m);

        Console.WriteLine(Account.DisplayAccount(account1));
        Console.WriteLine(Account.DisplayAccount(account2));

        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount);

        Console.WriteLine(Account.DisplayAccount(account1));
        Console.WriteLine(Account.DisplayAccount(account2));

        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount);

        Console.WriteLine(Account.DisplayAccount(account1));
        Console.WriteLine(Account.DisplayAccount(account2));

        Console.Write("\nEnter withdraw about for account1: ");
        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
        if (withdrawAmount > account1.Balance)
        {
            Console.WriteLine("Withdrawl amount exceeded account balance.");
        }
        else
        {
            Console.WriteLine($"withdrawing {withdrawAmount:C} from account1 balance\n");
            account1.Withdraw(withdrawAmount);
            Console.WriteLine(Account.DisplayAccount(account1));
        }

        Console.Write("\nEnter withdraw about for account2: ");
        withdrawAmount = decimal.Parse(Console.ReadLine());
        if (withdrawAmount > account2.Balance)
        {
            Console.WriteLine("Withdrawl amount exceeded account balance.");
        }
        else
        {
            Console.WriteLine($"withdrawing {withdrawAmount:C} from account2 balance\n");
            account2.Withdraw(withdrawAmount);
            Console.WriteLine(Account.DisplayAccount(account2));
        }
        Console.Clear();

        Console.WriteLine(Account.DisplayAccount(account1));
        Console.WriteLine(Account.DisplayAccount(account2));

        Console.ReadLine();
    }
}
