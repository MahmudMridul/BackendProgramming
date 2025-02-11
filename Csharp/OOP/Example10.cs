
namespace Csharp.OOP
{
    public class Gandalf
    {
        public virtual void Method1()
        {
            Console.WriteLine("Gandalf 1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Gandalf 2");
            Method1();
        }
    }

    public class Bilbo : Gandalf
    {
        public override void Method1()
        {
            Console.WriteLine("Bilbo 1");
        }
    }

    public class Frodo : Bilbo
    {
        public override void Method1()
        {
            Console.WriteLine("Frodo 1");
            base.Method1();
        }

        public void Method3()
        {
            Console.WriteLine("Frodo 3");
        }
    }

    public class Gollum : Gandalf
    {
        public void Method3()
        {
            Console.WriteLine("Gollum 3");
        }
    }

    public class Example10
    {
        public static void Run()
        {
            Gandalf var1 = new Frodo();
            Gandalf var2 = new Bilbo();
            Gandalf var3 = new Gandalf();
            object var4 = new Bilbo();
            Bilbo var5 = new Frodo();
            object var6 = new Gollum();

            // Method calls
            var1.Method1();
            var2.Method1();
            var3.Method1();
            ((Gandalf)var4).Method1();
            var5.Method1();
            ((Gandalf)var6).Method1();

            var1.Method2();
            var2.Method2();
            var3.Method2();
            ((Gandalf)var4).Method2();
            var5.Method2();
            ((Gandalf)var6).Method2();

            //((Bilbo)var1).Method3();  // Runtime error: Bilbo doesn't have Method3
            ((Gandalf)var1).Method2();
            ((Frodo)var4).Method1();  // Will throw InvalidCastException
            ((Gandalf)var6).Method2();
            ((Gandalf)var4).Method1();
            ((Frodo)var6).Method3();  // Will throw InvalidCastException
            ((Frodo)var3).Method3();  // Will throw InvalidCastException
            ((Frodo)var5).Method3();
        }
    }
}
