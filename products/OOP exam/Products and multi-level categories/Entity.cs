using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exam.Products_and_multi_level_categories
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
