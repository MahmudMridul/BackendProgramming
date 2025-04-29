
namespace Csharp.Action
{
    public class ActionExample
    {
        public static void Run()
        {
            Action<string> print = data => Console.WriteLine(data);
            ProcessData("data", print);
        }

        public static void ProcessData(string data, Action<string> action)
        {
            string result = data.ToUpper();
            action(result);
        }
    }
}
