using Bank_Accounts;

User user1 = new User(1,"Azima","MAA","password");
User user2 = new User(2, "Akif", "ADNSU", "engineer");

Account account1 = new Account(1,"Saving Account",user1);
Account account2 = new Account(2, "Checking Account", user2);

user1.AddAccount(account1);
user2.AddAccount(account2);

account1.Deposit(1230);
account2.Deposit(1350);
account2.Withdraw(500);

Console.WriteLine($"Account Balance for {account1.Name}: {account1.GetBalance()}");
Console.WriteLine($"Account Balance for {account2.Name}: {account2.GetBalance()}");