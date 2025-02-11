
namespace Csharp.OOP
{
    internal class Example6
    {
        public static void Run()
        {

            // Test Questions:

            // 1. What will be the output of the following code?
            Hobbit hobbit1 = new E6Frodo(true, true, true);
            Hobbit hobbit2 = new E6Bilbo(false, false, 1);
            RingBearer bearer = new E6Frodo(true, false, false);
            E6Frodo E6Frodo = new E6Frodo(true, true, true);
            E6Gandalf E6Gandalf = new E6Gandalf(true);

            Console.WriteLine(hobbit1.GetPowerLevel());
            Console.WriteLine(hobbit2.GetPowerLevel());
            Console.WriteLine(bearer.GetPowerLevel());
            Console.WriteLine(E6Frodo.GetPowerLevel());

            // 2. What will be the output of these interactions?
            E6Gandalf.InteractWith(hobbit1);
            E6Gandalf.InteractWith(hobbit2);
            E6Gandalf.InteractWith(bearer);
            E6Gandalf.InteractWith(E6Frodo);

            // 3. What happens if we modify the E6Bilbo class to use 'override' instead of 'new' 
            // for GetPowerLevel()? Why?

            // 4. If we add this code, what will happen and why?
            RingBearer E6Bilbo = new E6Bilbo(true, true, 5);
            Console.WriteLine(E6Bilbo.GetPowerLevel());

            // 5. What would happen if we tried to access GetSecretInfo() from outside the classes?
            // Why can't we access it?

            // Extra Challenge: Predict method resolution order and explain why each method
            // is called in the above scenarios
        }
    }

    public class Hobbit
    {
        public string Name { get; protected set; }
        protected int Age { get; set; }
        private bool HasRing { get; set; }

        public Hobbit(string name, int age, bool hasRing)
        {
            Name = name;
            Age = age;
            HasRing = hasRing;
        }

        public virtual string GetPowerLevel()
        {
            return $"{Name}'s base power is: {(HasRing ? 50 : 5)}";
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} says: Good morning!");
        }

        protected virtual string GetSecretInfo()
        {
            return $"{Name} is a simple hobbit.";
        }
    }

    public class RingBearer : Hobbit
    {
        protected bool IsCurrentBearer { get; set; }

        public RingBearer(string name, int age, bool hasRing, bool isCurrentBearer)
            : base(name, age, hasRing)
        {
            IsCurrentBearer = isCurrentBearer;
        }

        public override string GetPowerLevel()
        {
            string basePower = base.GetPowerLevel();
            return IsCurrentBearer
                ? $"{basePower} + Ring Bearer Bonus: 100"
                : basePower;
        }

        protected override string GetSecretInfo()
        {
            return $"{base.GetSecretInfo()} But they also carried the One Ring.";
        }
    }

    public class E6Frodo : RingBearer
    {
        private bool HasMithrilArmor { get; set; }

        public E6Frodo(bool hasRing, bool isCurrentBearer, bool hasMithrilArmor)
            : base("E6Frodo", 33, hasRing, isCurrentBearer)
        {
            HasMithrilArmor = hasMithrilArmor;
        }

        public override void Speak()
        {
            Console.WriteLine("All right then, keep your secrets.");
        }

        public override string GetPowerLevel()
        {
            string bearerPower = base.GetPowerLevel();
            return HasMithrilArmor
                ? $"{bearerPower} + Mithril Armor Bonus: 75"
                : bearerPower;
        }

        protected override string GetSecretInfo()
        {
            return $"{base.GetSecretInfo()} And they wore mithril armor.";
        }
    }

    public class E6Bilbo : RingBearer
    {
        private int AdventureCount { get; set; }

        public E6Bilbo(bool hasRing, bool isCurrentBearer, int adventureCount)
            : base("E6Bilbo", 111, hasRing, isCurrentBearer)
        {
            AdventureCount = adventureCount;
        }

        public override void Speak()
        {
            Console.WriteLine("I don't know half of you half as well as I should like!");
        }

        public new string GetPowerLevel()
        {
            return $"E6Bilbo's power is unmeasurable after {AdventureCount} adventures!";
        }
    }

    public class Wizard
    {
        public string Name { get; private set; }
        protected string Color { get; set; }

        public Wizard(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public virtual void CastSpell()
        {
            Console.WriteLine($"{Name} casts a basic spell!");
        }
    }

    public class E6Gandalf : Wizard
    {
        private bool HasNarya { get; set; }

        public E6Gandalf(bool hasNarya) : base("E6Gandalf", "Grey")
        {
            HasNarya = hasNarya;
        }

        public override void CastSpell()
        {
            Console.WriteLine($"{Name} the {Color} " +
                (HasNarya ? "uses Narya's power!" : "casts an advanced spell!"));
        }

        public void InteractWith(Hobbit hobbit)
        {
            Console.WriteLine($"{Name} meets {hobbit.Name}");
            hobbit.Speak();
        }
    }
}

