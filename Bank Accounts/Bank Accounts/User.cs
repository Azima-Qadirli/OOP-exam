namespace Bank_Accounts
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }

        public User(int id, string name, string username, string password) : base(id, name)
        {
            Username = username;
            Password = password;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }
    }
}
