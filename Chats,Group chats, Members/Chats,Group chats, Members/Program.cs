using Chats_Group_chats__Members;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User(123,"Azima","Qadirli", "password");
        User user2 = new User(458,"Akif","cls","absnjn");

        PrivateChat privateChat = new PrivateChat(1,"Azima and Akif");
        privateChat.AddMember(user1);
        privateChat.AddMember(user2);

        GroupChat groupChat = new GroupChat(21,"Backend Development");
        groupChat.AddMember(user1);
        groupChat.AddMember(user2);

        Message privateMessage = new Message(154,"Hiii","How is life going?",user1,new List<User> { user2 }); 
        privateChat.SendMessage(privateMessage);

        Message groupMessage = new Message(658,"Meeting","Reminder: Meeting will be at 16.00", user1, new List<User> { user2});
        groupChat.SendMessage(groupMessage);


        Console.WriteLine("Private Message sent:");
        Console.WriteLine($"From: {privateMessage.Sender.Username} {privateMessage.Sender.Username}");
        Console.WriteLine($"To: {privateMessage.Receiver.FirstOrDefault()?.Username} {privateMessage.Receiver.FirstOrDefault()?.Username}");
        Console.WriteLine($"Content: {privateMessage.Content}");

        Console.WriteLine();

        Console.WriteLine("Group Message Sent:");
        Console.WriteLine($"From: {groupMessage.Sender.Username} {groupMessage.Sender.Username}");
        Console.WriteLine($"To Group: {groupChat.Name}");
        Console.WriteLine($"Content: {groupMessage.Content}");
    }
}