
namespace Csharp.OOP
{
    public class InVehicle
    {
        public InVehicle()
        {
            Console.WriteLine("InVehicle is created");
        }

        public virtual void Start()
        {
            Console.WriteLine("InVehicle is started");
        }

        public void Stop()
        {
            Console.WriteLine("InVehicle is stopped");
        }

        protected virtual void ProtectedExample()
        {
            Console.WriteLine("InVehicle protected method");
        }

        internal virtual void InternalExample()
        {
            Console.WriteLine("InVehicle internal method");
        }
    }

    public class InCar : InVehicle
    {
        public InCar()
        {
            Console.WriteLine("InCar is created");
        }

        public override void Start()
        {
            Console.WriteLine("InCar is started");
        }

        public new void Stop()
        {
            Console.WriteLine("InCar is stopped");
        }

        protected override void ProtectedExample()
        {
            Console.WriteLine("InCar protected method");
        }

        internal override void InternalExample()
        {
            // ProtectedExample(); can be called from here as 
            // it is a derived class.
            base.ProtectedExample();
            ProtectedExample();
            Console.WriteLine("InCar internal method");
        }
    }

    public class Inheritance
    {
        public static void Run()
        {
            InCar InCar = new InCar();
            InCar.Start();
            InCar.Stop();
            // following line is an error. because protected member can be called 
            // within the same class or derived class only. here ProectedExample()
            // is called from a different class.
            //InCar.ProtectedExample();

            InCar.InternalExample();
        }
    }
}
