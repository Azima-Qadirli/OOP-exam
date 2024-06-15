using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats_Group_chats__Members
{
    public class Message:Entity
    {
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
        public  User Sender { get; set; }
        public List<User>Receiver { get; set; }

        public Message(int id,string name,string content, User sender, List<User> receiver ):base(id,name)
        {
            Content = content;
            Sender = sender;
            Receiver = receiver;
            TimeStamp = DateTime.Now;
        }
    }
}
