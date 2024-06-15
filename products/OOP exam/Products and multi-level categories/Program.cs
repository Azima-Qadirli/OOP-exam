using OOP_exam;
using OOP_exam.Products_and_multi_level_categories;

public class Program
{
    static void Main(string[] args)
    {
        var rootCategory = new Category(1, "Electronics");
        var laptops = new Category(2, "Laptops");
        var smartphones = new Category(3, "Smartphones");
        var tablet = new Category(4, "Tablets");

        rootCategory.AddSubcategory(laptops);
        rootCategory.AddSubcategory(smartphones);
        rootCategory.AddSubcategory(tablet);

        var laptop1 = new Product(102, "Asus", 2400, 5);
        var laptop2 = new Product(230, "HP", 1500, 3);
        var smartphones1 = new Product(541, "Samsung", 700, 10);
        var tablet1 = new Product(001, "IPad", 2000, 3);

        laptops.AddProduct(laptop1);
        laptops.AddProduct(laptop2);
        smartphones.AddProduct(smartphones1);
        tablet.AddProduct(tablet1);


        rootCategory.PrintCategories();
    }
}
