using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public Supplier Supplier { get; set; }

        public Product(string name, int id, decimal price, Supplier supplier) : base(name, id)
        {
            Price = price;
            Supplier = supplier;
        }
    }

}
