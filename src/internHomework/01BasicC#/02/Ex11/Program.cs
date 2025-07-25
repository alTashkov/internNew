struct BankAccount
{
    public string FirstName;
    public string MiddleName;
    public string LastName;
    public int Balance;
    public string BankName;
    public string IBAN;
    public string CreditCard1;
    public string CreditCard2;
    public string CreditCard3;

}

class Program
{

    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.FirstName = "Alexandar";
        account.MiddleName = "Petrov";
        account.LastName = "Tashkov";
        account.Balance = 0;
        account.BankName = "Central Cooperative Bank";
        account.IBAN = "BG80 BNBG 9661 1020 3456 78";
        account.CreditCard1 = "4111 1111 1111 1111";
        account.CreditCard2 = "5555 5555 5555 4444";
        account.CreditCard3 = "3782 822463 10005";
    }
}