﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats_Group_chats__Members
{
    public  class PrivateChat : Chat
    {
        public PrivateChat(int id, string name):base(id,name)
        {
            
        }
        public override void SendMessage(Message message)
        {
            
        }
    }
}
