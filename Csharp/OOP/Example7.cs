namespace Csharp.OOP
{
    public class Drink : Bite
    {
        public override void Method3()
        {
            Console.WriteLine("Drink 3");
        }
    }

    public class Sip : Gulp
    {
        public void Method1()
        {
            Console.WriteLine("Sip 1");
        }

        public override void Method3()
        {
            Console.WriteLine("Sip 3");
        }
    }

    public class Bite : Gulp
    {
        public void Method1()
        {
            Console.WriteLine("Bite 1");
        }

        public override void Method3()
        {
            Console.WriteLine("Bite 3");
            base.Method3();
        }
    }

    public class Gulp
    {
        public void Method2()
        {
            Console.WriteLine("Gulp 2");
            Method3();
        }

        public virtual void Method3()
        {
            Console.WriteLine("Gulp 3");
        }
    }

    // Test code with type casting and method calls
    public class Example7
    {
        public static void Run()
        {
            object var1 = new Bite();
            Gulp var2 = new Gulp();
            Gulp var3 = new Sip();
            Bite var4 = new Drink();
            object var5 = new Gulp();
            Gulp var6 = new Drink();


            ((Gulp)var1).Method2();
            var2.Method2();
            var3.Method2();
            var4.Method2();
            ((Gulp)var5).Method2();
            var6.Method2();

            ((Gulp)var1).Method3();
            var2.Method3();
            var3.Method3();
            var4.Method3();
            ((Gulp)var5).Method3();
            var6.Method3();

            ((Sip)var6).Method1();  // Will throw InvalidCastException
            ((Gulp)var1).Method2();
            ((Bite)var1).Method3();
            ((Bite)var6).Method1();
            ((Drink)var1).Method1(); // Will throw InvalidCastException
            ((Drink)var4).Method2();
            ((Bite)var3).Method1();  // Will throw InvalidCastException
        }
    }
}
