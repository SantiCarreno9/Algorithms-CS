public class Account
{
    public int AccountNumber { get; private set; }
    public string? CustomerName { get; private set; }
    public double AccountBalance { get; private set; }

    public Account(int accountNumber, string? customerName, double accountBalance)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
        AccountBalance = accountBalance;
    }
}

