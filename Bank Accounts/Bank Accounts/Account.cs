namespace Bank_Accounts
{
    public class Account : Entity
    {
        public decimal Balance { get; private set; }
        public User Owner { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        public Account(int id, string name, User owner) : base(id, name)
        {
            Owner = owner;
            Transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction(TransactionType.Deposit, amount));
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add(new Transaction(TransactionType.Withdrawal, amount));
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
