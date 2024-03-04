using System;

namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }

        // Additional fields
        public abstract int Age { get; set; }
        public abstract string Species { get; set; }

        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Dog : Animal
    {
        // Properties
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Species { get; set; }

        // Constructors
        public Dog() : this("", 0, "")
        {
        }

        public Dog(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        // Override the Describe method
        public override string Describe()
        {
            return $"I am a {Species}\nMy name is {Name}, and I am {Age} years old.";
        }
    }

    class Cat : Animal
    {
        // Properties
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Species { get; set; }

        // Constructors
        public Cat() : this("", 0, "")
        {
        }

        public Cat(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        // Override the Describe method
        public override string Describe()
        {
            return $"I am a {Species}\nMy name is {Name}, and I am {Age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Dog object using the default constructor
            Dog dog1 = new Dog();
            dog1.Name = "Colin";
            dog1.Age = 3;
            dog1.Species = "Dog";
            Console.WriteLine(dog1.whatAmI());
            Console.WriteLine(dog1.Describe());
            Console.WriteLine();

            // Create Cat object using the parameterized constructor
            Cat cat1 = new Cat("Parmida", 2, "Cat");
            Console.WriteLine(cat1.whatAmI());
            Console.WriteLine(cat1.Describe());
        }
    }
}