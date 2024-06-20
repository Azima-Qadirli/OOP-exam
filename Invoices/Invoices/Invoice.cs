using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    public class Invoice:Entity
    {
        public DateTime Date {  get; set; }
        public List<InvoiceItem> Items { get; set; }

        public Invoice(string name,int id,DateTime date):base(name,id)
        {
            Date = date;
            Items = new List<InvoiceItem>();
        }

        public void AddItem(InvoiceItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(InvoiceItem item) 
        {  
            Items.Remove(item); 
        }
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach(var item in Items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
    }
}
