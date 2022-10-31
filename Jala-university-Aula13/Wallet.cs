namespace Jala_university_Aula13;

public class Wallet : IWallet
{
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    public decimal Balance { get;  set; }
    
}

public interface IWallet
{
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    public decimal Balance { get; set; }
}