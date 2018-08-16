class Account
{
    public string Name { get; set; }
    private decimal balance;

    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            balance = balance + depositAmount;
        }
    }

    public void Withdraw(decimal withdrawAmount)
    {
        if (withdrawAmount > 0.0m)
        {
            balance = balance - withdrawAmount;
        }
    }

    public static string DisplayAccount(Account accountToDisplay)
    {
        return $"{accountToDisplay.Name}'s Balance: {accountToDisplay.Balance:C}";
    }
}

