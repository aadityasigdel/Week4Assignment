public class BankAccount
{
    // Private field 
    private double balance;

    // Constructor
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    //  method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Overloaded Deposit method  Polymorphism
    public void Deposit(double amount, string description)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} for: {description}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    //  method to withdraw money 
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Withdrawal Failed.");
        }
    }

    //  method to read the balance
    public double GetBalance()
    {
        return balance;
    }
}
