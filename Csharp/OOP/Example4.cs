
namespace Csharp.OOP
{
    internal class Example4
    {
        public static void Run()
        {
            Vehicle v = new Vehicle();
            Car c = new Car();
            ElectricCar e = new ElectricCar();

            Console.WriteLine(v.GetDescription());
            Console.WriteLine(c.GetDescription());
            Console.WriteLine(e.GetDescription());
        }
    }

    public class Vehicle
    {
        protected string _type;

        public Vehicle()
        {
            _type = "Generic";
            SetupVehicle();
        }

        protected virtual void SetupVehicle()
        {
            Console.WriteLine($"Setting up {_type} vehicle");
        }

        public virtual string GetDescription()
        {
            return $"A {_type} vehicle";
        }
    }

    public class Car : Vehicle
    {
        protected override void SetupVehicle()
        {
            _type = "Car";
            base.SetupVehicle();
            Console.WriteLine("Adding car specific features");
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with four wheels";
        }
    }

    public class ElectricCar : Car
    {
        protected override void SetupVehicle()
        {
            base.SetupVehicle();
            Console.WriteLine("Adding electric components");
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " and electric motor";
        }
    }


}
