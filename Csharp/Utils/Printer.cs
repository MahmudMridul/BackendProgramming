using System.Reflection;
using System.Text;

namespace Csharp.Utils
{
    public class Printer
    {
        public static void Print<T>(IEnumerable<T> items, string nameofItems = "")
        {
            if (items == null)
            {
                Console.WriteLine("NULL\n");
                return;
            }

            if (!items.Any())
            {
                Console.WriteLine("EMPTY\n");
                return;
            }

            if (!string.IsNullOrEmpty(nameofItems))
            {
                Console.WriteLine(nameofItems);
            }

            // if a type has multiple properties, it's considered a complex type.
            // if the type has exactly one property but that property is NOT named "Length" or "Count".
            // This is a heuristic to handle collections like arrays, lists, and strings
            // which have a single property but shouldn't be treated as complex objects.
            bool isComplexType = typeof(T).GetProperties().Length > 1 ||
                                (typeof(T).GetProperties().Length == 1 &&
                                typeof(T).GetProperties()[0].Name != "Length" &&
                                typeof(T).GetProperties()[0].Name != "Count");

            if (isComplexType)
            {
                PrintObjectCollection(items, nameofItems);
            }
            else
            {
                PrintBuiltinTypeCollection(items, nameofItems);
            }
        }

        public static void PrintBuiltinTypeCollection<T>(IEnumerable<T> items, string nameofItems = "")
        {
            foreach (T item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintObjectCollection<T>(IEnumerable<T> items, string nameofItems = "")
        {
            foreach (T item in items)
            {
                if (item == null)
                {
                    Console.WriteLine("NULL");
                    continue;
                }

                Type type = item.GetType();
                PropertyInfo[] properties = type.GetProperties();
                StringBuilder sb = new StringBuilder();
                sb.Append("{ ");
                bool isFirst = true;

                foreach (PropertyInfo property in properties)
                {
                    if (!isFirst)
                    {
                        sb.Append(", ");
                    }
                    object? value = property.GetValue(item);
                    string valueString = "";

                    if (value is string)
                    {
                        valueString = $"\"{value}\"";
                    }
                    else
                    {
                        valueString = value?.ToString() ?? "NULL";
                    }
                    sb.Append($"{property.Name} = {valueString}");
                    isFirst = false;
                }
                sb.Append(" }");
                Console.WriteLine(sb.ToString());
            }
        }

    }
}
