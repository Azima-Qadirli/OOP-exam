using OOP_exam.Products_and_multi_level_categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exam
{
    public class Category:Entity
    {
        
        public List<Category> SubCategories { get; private set;}
        public List<Product> Products { get; private set;}


        public Category(int id, string name):base(id,name) // this is constructor
        {
            Name = name;
            ID = id;
            SubCategories = new List<Category>();
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
        public void AddSubcategory(Category subcategory)
        {
            SubCategories.Add(subcategory);
        }
        public void RemoveSubCategory(Category subcategory)
        {
            if (SubCategories.Contains(subcategory))
            {
                SubCategories.Remove(subcategory);
            }
        }
        public Product FindProductByID(int productId)
        {
            return Products.Find(p=>p.ID==productId);
        } 
        public List<Product> GetAllProducts()
        {
            var allProducts = new List<Product>(Products);
            foreach (var subcategory in SubCategories)
            {
                allProducts.AddRange(subcategory.GetAllProducts());
            }
            return allProducts;
        }
        public void PrintCategories(string prefix = "")
        {
            Console.WriteLine($"{prefix}{Name}");
            foreach (var subcategory in SubCategories)
            {
                subcategory.PrintCategories($"{prefix}- ");
            }
        }

    }
}
