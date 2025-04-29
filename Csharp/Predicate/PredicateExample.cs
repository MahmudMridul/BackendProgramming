
using Csharp.Utils;
using System;
using System.Linq;

namespace Csharp.Predicate
{
    public class PredicateExample
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                new Product(101, "Wireless Headphones", "Sony", 89.99m, 50, 4.5, "Audio"),
                new Product(102, "Mechanical Keyboard", "Logitech", 129.99m, 30, 4.7, "Peripherals"),
                new Product(103, "27\" 4K Monitor", "LG", 349.99m, 15, 4.8, "Monitors"),
                new Product(104, "Bluetooth Speaker", "JBL", 59.99m, 75, 4.3, "Audio"),
                new Product(105, "External SSD 1TB", "Samsung", 129.99m, 40, 4.9, "Storage"),
                new Product(106, "Gaming Mouse", "Razer", 49.99m, 60, 4.6, "Peripherals"),
                new Product(107, "Smart Watch", "Apple", 399.99m, 25, 4.8, "Wearables"),
                new Product(108, "Noise Cancelling Headphones", "Bose", 299.99m, 20, 4.7, "Audio"),
                new Product(109, "Wireless Charger", "Anker", 29.99m, 100, 4.2, "Accessories"),
                new Product(110, "Laptop Backpack", "Targus", 79.99m, 45, 4.4, "Accessories")
            };

            Predicate<Product> isAudioCategory = product => product.Category == "Audio";
            Predicate<Product> isPeripheral = product => product.Category == "Peripherals";
            Predicate<Product> isCheap = product => product.Price < 100m;

            IEnumerable<Product> audioCategory = products.FindAll(isAudioCategory);
            Printer.Print(audioCategory, nameof(audioCategory));

            List<Product> peripherals = FilterProducts(products, isPeripheral);
            Printer.Print(peripherals, nameof(peripherals));

            List<Product> filtered = ApplyFilters(products, isAudioCategory, isCheap);
            Printer.Print(filtered, nameof(filtered));

            
        }

        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
        {
            return products.FindAll(condition);
        }

        public static List<Product> ApplyFilters(List<Product> products, params Predicate<Product>[] filters)
        {
            List<Product> filteredProducts = new List<Product>(products);

            foreach (var filter in filters)
            {
                filteredProducts = filteredProducts.FindAll(filter);
            }
            return filteredProducts;
        }

    }

    public class Product(int id, string name, string brand, decimal price, int stockQuantity, double rating, string category)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Brand { get; set; } = brand;
        public decimal Price { get; set; } = price;
        public int StockQuantity { get; set; } = stockQuantity;
        public double Rating { get; set; } = rating;
        public string Category { get; set; } = category;
    }
}
