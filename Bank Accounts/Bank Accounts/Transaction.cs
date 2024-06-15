namespace Bank_Accounts
{
    public class Transaction
    {
        public TransactionType Type { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public Transaction(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
            TimeStamp = DateTime.Now;
        }
    }
}
