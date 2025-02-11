
namespace Csharp.OOP
{
    internal class Example1
    {
        public static void Run()
        {
            // What will be the output?
            Parent p1 = new Parent();
            Parent p2 = new Child();
            Child c1 = new Child();

            p1.Display();
            p2.Display();
            c1.Display();
        }
    }

    public class Parent
    {
        public virtual string GetInfo()
        {
            return "Parent Info";
        }

        public virtual void Display()
        {
            Console.WriteLine($"Display: {GetInfo()}");
        }
    }

    public class Child : Parent
    {
        public override string GetInfo()
        {
            return "Child Info";
        }
    }
}


