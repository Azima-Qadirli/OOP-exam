namespace Bank_Accounts
{
    public class Bank
    {
        private List<User> Users { get; set; }

        public Bank()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }

        public User GetUserByID(int userId)
        {
            return Users.FirstOrDefault(u => u.ID == userId);
        }
    }
}
