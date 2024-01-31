namespace SOLIDPrinciples_04.LSP;

public class CurrentAccount : Account
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        Balance -= amount; // Current accounts may allow overdrafts
    }
}