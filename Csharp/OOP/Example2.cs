namespace Csharp.OOP
{
    internal class Example2
    {
        public static void Run()
        {
            Animal a1 = new Animal();
            Console.WriteLine($"a1: {a1.Name}");

            Dog d1 = new Dog();
            Console.WriteLine($"d1: {d1.Name}, {d1.Breed}");

            Dog d2 = new Dog("Rex", "German Shepherd");
            Console.WriteLine($"d2: {d2.Name}, {d2.Breed}");
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Name = "Unknown";
            Console.WriteLine("Animal constructor");
        }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"Animal constructor with name: {name}");
        }
    }

    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog() : base()
        {
            Breed = "Unknown";
            Console.WriteLine("Dog constructor");
        }

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
            Console.WriteLine($"Dog constructor with breed: {breed}");
        }
    }

}
