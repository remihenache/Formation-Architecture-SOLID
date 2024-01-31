namespace SOLIDPrinciples_04.LSP;

public abstract class Account
{
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
    public decimal Balance { get; protected set; }
}