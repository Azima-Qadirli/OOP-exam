using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exam.Products_and_multi_level_categories
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(int id, string name, decimal price, int stockQuantity) : base(id, name)
        { // this is constructor.

            ID = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
        public void UpdateStock(int quantity)
        {
            StockQuantity += quantity;
        }
        public void ApplyDiscount(decimal DiscountPercentage)
        {
            Price -= Price * DiscountPercentage / 100;
        }
        public void ReStock(int newStockQuantity)
        {
            StockQuantity = newStockQuantity;
        }
        public bool IsInStock()
        {
            return StockQuantity > 0;
        }
        public string DisplayProductInfo()
        {
            return $"Product ID: {ID}\nName: {Name}\nPrice: {Price}\nQuantity: {StockQuantity}";
        }

        public void SetPrice(decimal newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
            }
            else
            {
                Console.WriteLine("The price of product can not be negative:");
            }
        }
    }


}
