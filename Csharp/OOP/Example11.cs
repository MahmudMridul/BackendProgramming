
namespace Csharp.OOP
{
    public class Paper
    {
        public virtual void Method2()
        {
            Console.WriteLine("Paper 2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Paper 3");
            Method2();
        }
    }

    public class Clip : Paper
    {
        public override void Method2()
        {
            Console.WriteLine("Clip 2");
            base.Method2();
        }
    }

    public class Stapler : Clip
    {
        public void Method1()
        {
            Console.WriteLine("Stapler 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Stapler 2");
        }
    }

    public class Pen : Paper
    {
        public void Method1()
        {
            Console.WriteLine("Pen 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Pen 2");
        }
    }

    public class Example11
    {
        public static void Run()
        {
            Paper var1 = new Pen();
            Stapler var2 = new Stapler();
            Paper var3 = new Stapler();
            Paper var4 = new Paper();
            object var5 = new Stapler();
            Paper var6 = new Clip();

            // Method calls
            var1.Method2();
            var2.Method2();
            var3.Method2();
            var4.Method2();
            ((Paper)var5).Method2();
            var6.Method2();

            ((Pen)var1).Method1();
            var2.Method1();
            ((Stapler)var3).Method1();

            var1.Method3();
            var2.Method3();
            var3.Method3();
            var4.Method3();

            ((Pen)var1).Method1();
            ((Stapler)var3).Method1();
            ((Clip)var3).Method3();
            //((Clip)var5).Method1();     // Will throw InvalidCastException
            ((Pen)var5).Method1();      // Will throw InvalidCastException
            ((Clip)var6).Method2();
            ((Stapler)var6).Method3();  // Will throw InvalidCastException
        }
    }
}
