namespace Csharp.OOP
{
    internal class Example5
    {
        public static void Run()
        {
            // What will be the output?
            IShape[] shapes = new IShape[]
            {
                 new Circle(5),
                new Square(4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetInfo());
                Console.WriteLine($"Area: {shape.GetArea():F2}");
            }
        }
    }

    public interface IShape
    {
        double GetArea();
        string GetInfo();
    }

    public abstract class Shape : IShape
    {
        protected string _name;

        public Shape(string name)
        {
            _name = name;
        }

        public abstract double GetArea();

        public virtual string GetInfo()
        {
            return $"This is a {_name}";
        }
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius) : base("Circle")
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" with radius {_radius}";
        }
    }

    public class Square : Shape
    {
        private double _side;

        public Square(double side) : base("Square")
        {
            _side = side;
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}

