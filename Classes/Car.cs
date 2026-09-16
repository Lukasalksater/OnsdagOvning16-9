using OnsdagÖvning16_9.Abstract_Classes;
namespace OnsdagÖvning16_9.Classes
{
    public class Car : Vehicle
    {
        // Private Attributes
        private string Type = "Car";

        // Getter, no setters for Type, as it is a constant value for this class and its subclasses
        public string type
        {
            get { return Type; }
        }


        // Constructor
        public Car(string make, string model, int year) : base(make, model, year)
        {

        }

        // Implement abstract methods

        public override void Drive(bool isUnique)
        {
            if (isUnique)
            {
                Console.WriteLine($"The {Make} {Model} is driving uniquely.");
            }
            else
                Console.WriteLine($"The {Make} {Model} is driving.");
        }

        public override void Brake(bool isUnique)
        {
            if (isUnique)
            {
                Console.WriteLine($"The {Make} {Model} is braking uniquely.");
            }
            else
                Console.WriteLine($"The {Make} {Model} is braking.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }

        public override void FindLocation()
        {
            Console.WriteLine($"The {Make} {Model} is located at the parking lot.");
        }
    }
}
