namespace SOLIDPrinciples_04.LSP;

public static class Program
{
    public static void Main(string[] args)
    {
        Account account = new SavingsAccount();
        account.Deposit(new decimal(1000.00));

        BankingAppWithdrawalService withdrawalService = new BankingAppWithdrawalService(account);
        withdrawalService.Withdraw(new decimal(100.00));
    }
}