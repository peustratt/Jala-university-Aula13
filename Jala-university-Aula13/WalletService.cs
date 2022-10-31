namespace Jala_university_Aula13;

public class WalletService : IWalletService
{
    private readonly IWallet _wallet;
    public WalletService(IWallet wallet)
    {
        _wallet = wallet;
    }

    public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount)
    {
        if (!Currencies.Availables.TryGetValue(outgoingCurrency,out var to))
        {
            throw new ArgumentException("Invalid currency");
        }

        if (amount < 50)
        {
            throw new InvalidOperationException("amount below expected");
        }

        if (amount > _wallet.Balance)
        {
            throw new ArgumentException();
        }
       
        var total = (amount * to) - 0.01M;
        
        return new Tuple<string, decimal>(outgoingCurrency, total);
    }
    
    public void AddToBalance(decimal amount)
    {
        _wallet.Balance += amount;
    }

    public decimal GetBalance()
    {
        return _wallet.Balance;
    }
}

public interface IWalletService
{
    public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount);
    public void AddToBalance(decimal amount);

    public decimal GetBalance();
}