
using Csharp.Utils;

namespace Csharp.Func
{
    public class FuncEx
    {
        public static void Run()
        {
            DataTransformation();
            CustomCalculationInLINQ();
        }

        public static void DataTransformation()
        {
            // Transform a list of strings to a list of their lengths
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            Func<string, int> stringToLength = (s) => s.Length;

            // Using Select to map each string to its length
            // Also makes stringToLength logic reusable
            List<int> nameLengths = names.Select(stringToLength).ToList();
            Printer.Print(nameLengths, nameof(nameLengths));
        }

        public static void CustomCalculationInLINQ()
        {
            var products = new[]
            {
                new { Name = "Laptop", Price = 1200.0 },
                new { Name = "Phone", Price = 700.0 },
                new { Name = "Tablet", Price = 500.0 },
                new { Name = "Desktop", Price = 1100.0 },
            };

            Func<double, double> calculateDiscount = (price) => price > 1000 ? price * 0.85 : price * 0.95;

            var discountedProducts = products.Select(p => new { p.Name, OldPrice = p.Price, DiscountedPrice = calculateDiscount(p.Price) });
            Printer.Print(discountedProducts, nameof(discountedProducts));
        }
    }
}
