using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    public class Supplier : Entity
    {
        public string ContactInfo { get; set; }
        public List<Product> Products { get; set; }

        public Supplier(string name, int id, string contactInfo) : base(name, id)
        {
            ContactInfo = contactInfo;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
    }
}
