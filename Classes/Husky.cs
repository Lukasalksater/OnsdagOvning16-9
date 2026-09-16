namespace OnsdagÖvning16_9.Classes
{
    public class Husky : Dog
    {
        // Constructor
        public Husky(string name, int age, int numberOfLegs, string breed) : base(name, age, numberOfLegs, breed)
        {

        }

        // Override methods

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Breed} howls!");
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{Name} the {Breed} runs even faster on snow!");
        }
    }
}
