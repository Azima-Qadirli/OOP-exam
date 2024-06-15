using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats_Group_chats__Members
{
    public abstract class Chat:Entity
    {

        protected List<User> Members {  get; set; }
        protected List<Message> Messages {  get; set; }

        protected Chat(int id, string name):base(id,name)
        {
            Members = new List<User>();
            Messages = new List<Message>();
        }


        public abstract void SendMessage(Message message);

        public void AddMember(User user)
        {
            Members.Add(user);
        } 
        public void RemoveMember(User user)
        {
            Members.Remove(user);
        }
    }
}
