using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats_Group_chats__Members
{
    public  class User:Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id,string name,string username,string password):base(id,name)
        {
            Username = username;
            Password = password;
        }

        public void SendMessage(string messageContent,Entity recivier )
        {

        }
    }
}
