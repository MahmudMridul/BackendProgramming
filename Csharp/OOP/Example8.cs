
namespace Csharp.OOP
{
    public class Blue
    {
        public virtual void Method1()
        {
            Console.WriteLine("Blue 1");
            Method2();
        }

        public virtual void Method2()
        {
            Console.WriteLine("Blue 2");
        }
    }

    public class Red : Blue
    {
        public override void Method2()
        {
            Console.WriteLine("Red 2");
            base.Method2();
        }
    }

    public class Green : Red
    {
        public new void Method1()
        {
            Console.WriteLine("Green 1");
        }

        public void Method3()
        {
            Console.WriteLine("Green 3");
        }
    }

    public class White : Red
    {
        public void Method2()
        {
            Console.WriteLine("White 2");
        }

        public void Method3()
        {
            Console.WriteLine("White 3");
        }
    }

    public class Example8
    {
        public static void Run()
        {
            Blue var1 = new Blue();
            Green var2 = new Green();
            object var3 = new White();
            Red var4 = new Green();
            Blue var5 = new Red();
            Blue var6 = new White();

            // Method calls
            var1.Method1();
            var2.Method1();
            ((Blue)var3).Method1();
            var4.Method1();

            var1.Method2();
            var2.Method2();
            ((White)var3).Method2();
            var4.Method2();

            var2.Method3();
            ((White)var3).Method3();
            ((White)var4).Method3();  // Will throw InvalidCastException
            ((Green)var5).Method3();  // Will throw InvalidCastException
            ((Red)var5).Method1();
            ((Green)var6).Method3();  // Will throw InvalidCastException
        }
    }
}
