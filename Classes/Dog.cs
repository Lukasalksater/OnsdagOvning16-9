using OnsdagÖvning16_9.Abstract_Classes;
namespace OnsdagÖvning16_9.Classes
{
    public class Dog : Animal 
    {
        // Attributes 

        // Private field for species, since all dogs are of the same species, we can hardcode it to "Dog"
        private string Species { get; set; } = "Dog"; 
        public string Breed { get; set; }

        // Getter, no setters for Species since it's a constant value for every subclass of dog

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
        public override void MakeSound(bool isUnique)
        {
            if (isUnique)
            {
                if (Breed.ToLower() == "husky") // checks if the breed is husky, if so, it will make a unique howl sound
                {
                    Console.WriteLine("Awoo! (Unique howl)");
                }
                else
                    Console.WriteLine("Woof! (Unique bark)");
            }
            else
            {
                Console.WriteLine("Woof!");
            }
        }
        public override void Move(bool isUnique)
        {
            if (isUnique)
            {
                if (Breed.ToLower() == "husky") // checks if the breed is husky, if so, it will make a unique run sound
                {
                    Console.WriteLine("The Husky runs through the snow with ease!");
                }
                else
                    Console.WriteLine($"The {Breed} runs swiftly.");
            }
            else
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

