namespace SOLIDPrinciples_04.LSP;

public class BankingAppWithdrawalService {
    private Account account;

    public BankingAppWithdrawalService(Account account) {
        this.account = account;
    }

    public void Withdraw(decimal amount) {
        account.Withdraw(amount);
    }
}