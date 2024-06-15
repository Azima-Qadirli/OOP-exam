using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats_Group_chats__Members
{
    public abstract class Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        protected Entity(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
