namespace Csharp.OOP
{
    internal class Example3
    {
        public static void Run()
        {
            Base b = new Derived();
            Derived d = new Derived();
            b.Method1();
            b.Method2();
            d.Method1();
            d.Method2();
        }
    }

    public class Base
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Base Method2");
        }
    }

    public class Derived : Base
    {
        public override void Method1()
        {
            Console.WriteLine("Derived Method1");
        }

        public new void Method2()
        {
            Console.WriteLine("Derived Method2");
        }
    }
}
