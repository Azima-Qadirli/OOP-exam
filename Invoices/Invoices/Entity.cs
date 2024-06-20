using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int ID { get; set; }

        protected Entity(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }

}
