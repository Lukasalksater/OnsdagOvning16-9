using OnsdagÖvning16_9.Abstract_Classes;
namespace OnsdagÖvning16_9.Classes
{
    public class Dog : Animal 
    {
        // Private Attributes 
        private string Species { get; set; } = "Dog"; // Hardcoded the species because it can not be anything else

        // Attributes

        public string Breed { get; set; }



        // Getters, no setters for Species since it's a constant value for every subclass of dog

        public string species 
        {
            get { return Species; }
        }

        // Constructor
        public Dog(string name, int age, int numberOfLegs, string breed) : base(name, age, numberOfLegs)
        {
            Breed = breed;
        }
        // Implement abstract methods
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void Move()
        {
            Console.WriteLine($"The {Breed} runs on its {NumberOfLegs} legs.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name},Breed: {Breed}, Species: {Species}, Age: {Age}, Number of Legs: {NumberOfLegs}");
        }

        public override void FindLocation()
        {
            Console.WriteLine($"{Name} the {Breed} is located at the dog park.");
        }
    }
    
}

