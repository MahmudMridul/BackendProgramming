
namespace Csharp.OOP
{
    public class Chair
    {
        public virtual void Method2()
        {
            Console.WriteLine("Chair 2");
        }
    }

    public class Table : Chair
    {
        public virtual void Method1()
        {
            Console.WriteLine("Table 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Table 2");
            base.Method2();
        }

        public virtual void Method3()
        {
            Console.WriteLine("Table 3");
            Method1();
        }
    }

    public class Couch : Table
    {
        public override void Method1()
        {
            Console.WriteLine("Couch 1");
        }
    }

    public class Lamp : Chair
    {
        public void Method1()
        {
            Console.WriteLine("Lamp 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Lamp 2");
        }
    }

    public class Example9
    {
        public static void Run()
        {
            Table var1 = new Table();
            Chair var2 = new Table();
            Table var3 = new Couch();
            Chair var4 = new Lamp();
            Chair var5 = new Couch();
            object var6 = new Chair();

            // Method calls
            var1.Method2();
            var2.Method2();
            var3.Method2();
            var4.Method2();
            var5.Method2();
            ((Chair)var6).Method2();

            var1.Method1();
            ((Table)var2).Method1();
            var3.Method1();
            ((Lamp)var4).Method1();

            var1.Method3();
            ((Table)var2).Method3();
            var3.Method3();

            ((Lamp)var4).Method1();
            ((Lamp)var2).Method1();  // Will throw InvalidCastException
            ((Table)var5).Method1();
            ((Couch)var1).Method1();  // Will throw InvalidCastException
            ((Chair)var6).Method2();
            ((Couch)var5).Method3();
            ((Table)var5).Method3();
        }
    }
}
